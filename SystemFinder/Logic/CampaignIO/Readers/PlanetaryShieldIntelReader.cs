using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PlanetaryShieldIntelReader(IEventReader eventReader, IPlanetReader planetReader)
        : IPlanetaryShieldIntelReader
    {
        public void Read(XElement current, GalaxyData data)
        {
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
