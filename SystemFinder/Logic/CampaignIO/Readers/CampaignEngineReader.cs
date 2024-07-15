using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CampaignEngineReader(HyperspaceReader hyperspaceReader, StarSystemsReader starSystemsReader)
    {
        public void Read(XDocument root, GalaxyData data)
        {
            var campaign = root.Element("CampaignEngine")!;

            var hyperspace = campaign.Element("hyperspace");
            var starSystems = campaign.Element("starSystems");

            if (hyperspace is not null)
            {
                hyperspaceReader.Read(hyperspace, data);
            }

            if (starSystems is not null)
            {
                starSystemsReader.Read(starSystems, data);
            }
        }
    }
}
