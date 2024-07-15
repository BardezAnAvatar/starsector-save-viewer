using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PersonReader(MarketReader marketReader) : IPersonReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var market = current.Element("market");

            if (market is not null)
            {
                marketReader.Read(market, data);
            }
        }
    }
}
