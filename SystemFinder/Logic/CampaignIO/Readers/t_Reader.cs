using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class t_Reader(ILogger<t_Reader> logger, IcL_Reader clReader, IOrbitReader orbitReader,
        IWhereReader whereReader) : It_Reader
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
                orbitReader.Read(orbit, data);
            }

            if (where is not null)
            {
                whereReader.Read(where, data);
            }
        }
    }
}
