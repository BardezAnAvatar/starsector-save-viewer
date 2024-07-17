using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class SavedObjectReader(ILogger<SavedObjectReader> logger, ILocationTokenReader locReader,
        ICentReader centReader, Lazy<IFleetReader> fltReader, IPlanetReader plntReader) : ISavedObjectReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var saved = current.Element("saved");

            var locationTokens = saved?.Elements("LocationToken");
            var cents = saved?.Elements("CCEnt");
            var fleets = saved?.Elements("Flt");
            var planets = saved?.Elements("Plnt");

            if (locationTokens is not null && locationTokens.Any())
            {
                foreach (var element in locationTokens)
                {
                    locReader.Read(element, data);
                }
            }

            if (cents is not null && cents.Any())
            {
                foreach (var element in cents)
                {
                    centReader.Read(element, data);
                }
            }

            if (fleets is not null && fleets.Any())
            {
                foreach (var element in fleets)
                {
                    fltReader.Value.Read(element, data);
                }
            }

            if (planets is not null && planets.Any())
            {
                foreach (var element in planets)
                {
                    plntReader.Read(element, data);
                }
            }
        }
    }
}
