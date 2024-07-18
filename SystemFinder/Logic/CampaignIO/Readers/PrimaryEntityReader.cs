using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PrimaryEntityReader(ILogger<PrimaryEntityReader> logger, IcL_Reader clReader,
        Lazy<IOrbitReader> orbitReader)
        : IPrimaryEntityReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var cl = current.Element("cL");
            var orbit = current.Element("orbit");

            if (cl is not null)
            {
                clReader.Read(cl, data);
            }

            if (orbit is not null)
            {
                orbitReader.Value.Read(orbit, data);
            }
        }
    }
}
