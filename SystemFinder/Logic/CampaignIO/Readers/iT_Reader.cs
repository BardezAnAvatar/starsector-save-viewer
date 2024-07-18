using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class iT_Reader(ILogger<iT_Reader> logger, IOrbitReader orbitReader) : IiT_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var orbit = current.Element("orbit");

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }
        }
    }
}
