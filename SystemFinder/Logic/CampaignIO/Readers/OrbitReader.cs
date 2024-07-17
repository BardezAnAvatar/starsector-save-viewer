using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OrbitReader(ILogger<OrbitReader> logger, Is_Reader sReader, If_Reader fReader) : IOrbitReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var s = current.Element("s");
            var f = current.Element("f");

            if (s is not null)
            {
                sReader.Read(s, data);
            }

            if (f is not null)
            {
                fReader.Read(f, data);
            }
        }
    }
}
