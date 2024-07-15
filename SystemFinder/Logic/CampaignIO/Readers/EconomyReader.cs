using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class EconomyReader(MarketReader marketReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var e = current
                .Element("stepper")
                ?.Element("econ")
                ?.Element("markets")
                ?.Elements("Market")
                ;

            if (e is not null && e.Any())
            {
                foreach (var element in e)
                {
                    marketReader.Read(element, data);
                }
            }
        }
    }
}
