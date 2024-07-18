using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class LocationTokenReader(ILogger<LocationTokenReader> logger, Lazy<IOrbitReader> orbitReader)
        : ILocationTokenReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var orbit = current.Element("orbit");

            if (orbit is not null)
            {
                orbitReader.Value.Read(orbit, data);
            }
        }
    }
}
