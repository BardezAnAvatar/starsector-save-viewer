using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class EconomyReader(IMarketReader marketReader) : IEconomyReader
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
