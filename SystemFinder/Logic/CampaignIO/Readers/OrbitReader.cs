using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OrbitReader(ILogger<OrbitReader> logger, Is_Reader sReader,
        If_Reader fReader) : IOrbitReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var f = current.Element("f");
            var s = current.Element("s");
            var spOrbit = current.Element("sP")?.Element("orbit");

            if (f is not null)
            {
                fReader.Read(f, data);
            }

            if (s is not null)
            {
                sReader.Read(s, data);
            }

            if (spOrbit is not null)
            {
                Read(spOrbit, data);
            }
        }
    }
}
