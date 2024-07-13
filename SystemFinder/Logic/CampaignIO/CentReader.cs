using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class CentReader(MarketReader marketReader, MetadataReader meReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var market = current.Element("market");
            var me = current.Element("me");

            if (market is not null)
            {
                marketReader.Read(market, data);
            }

            if (me is not null)
            {
                meReader.Read(me, data);
            }
        }
    }
}
