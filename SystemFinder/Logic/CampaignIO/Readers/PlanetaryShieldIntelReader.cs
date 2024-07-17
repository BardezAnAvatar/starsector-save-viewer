using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PlanetaryShieldIntelReader(ILogger<PlanetaryShieldIntelReader> logger, IEventReader eventReader,
        IPlanetReader planetReader)
        : IPlanetaryShieldIntelReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var @event = current.Element("event");
            var planet = current.Element("planet");

            if (@event is not null)
            {
                eventReader.Read(@event, data);
            }

            if (planet is not null)
            {
                planetReader.Read(planet, data);
            }
        }
    }
}
