using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class StagesReader(IMarketReader marketReader, IOrbitReader orbitReader) : IStagesReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var market = current.Element("NexOrgStg")?.Element("market");
            var orbit = current.Element("NexTrvlStg")?.Element("to")?.Element("orbit");

            if (market is not null)
            {
                marketReader.Read(market, data);
            }

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }
        }
    }
}
