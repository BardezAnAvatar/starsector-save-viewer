using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CentReader(Lazy<IMarketReader> marketReader, IMetadataReader meReader) : ICentReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var market = current.Element("market");
            var me = current.Element("me");

            if (market is not null)
            {
                marketReader.Value.Read(market, data);
            }

            if (me is not null)
            {
                meReader.Read(me, data);
            }
        }
    }
}
