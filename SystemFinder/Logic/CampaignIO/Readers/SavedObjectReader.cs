using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class SavedObjectReader(LocationTokenReader locReader, CentReader centReader,
        FleetReader fltReader, PlanetReader plntReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var saved =
                current
                .Element("o")!
                .Element("saved")!
                ;

            var locationTokens = saved.Elements("LocationToken");
            var cents = saved.Elements("CCEnt");
            var fleets = saved.Elements("Flt");
            var planets = saved.Elements("Plnt");

            if (locationTokens.Any())
            {
                foreach (var element in locationTokens)
                {
                    locReader.Read(element, data);
                }
            }

            if (cents.Any())
            {
                foreach (var element in cents)
                {
                    centReader.Read(element, data);
                }
            }

            if (fleets.Any())
            {
                foreach (var element in cents)
                {
                    fltReader.Read(element, data);
                }
            }

            if (planets.Any())
            {
                foreach (var element in cents)
                {
                    plntReader.Read(element, data);
                }
            }
        }
    }
}
