using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class SavedObjectReader(LocationTokenReader locReader, CentReader centReader,
        FleetReader fltReader, PlanetReader plntReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var saved = current
                .Element("saved")
                ;

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
                foreach (var element in cents)
                {
                    fltReader.Read(element, data);
                }
            }

            if (planets is not null && planets.Any())
            {
                foreach (var element in cents)
                {
                    plntReader.Read(element, data);
                }
            }
        }
    }
}
