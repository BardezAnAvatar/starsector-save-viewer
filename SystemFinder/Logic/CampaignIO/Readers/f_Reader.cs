using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class f_Reader(ILogger<f_Reader> logger, Lazy<IOrbitReader> orbitReader, IcL_Reader clReader,
        IWhereReader whereReader)
        : If_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var cL = current.Element("cL");
            var orbit = current.Element("orbit");
            var where = current.Element("where");

            if (cL is not null)
            {
                clReader.Read(cL, data);
            }

            if (orbit is not null)
            {
                orbitReader.Value.Read(orbit, data);
            }

            if (where is not null)
            {
                whereReader.Read(where, data);
            }
        }
    }
}
