using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class StagesReader(ILogger<StagesReader> logger, Lazy<IMarketReader> marketReader,
        IOrbitReader orbitReader) : IStagesReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var market = current.Element("NexOrgStg")?.Element("market");
            var orbit = current.Element("NexTrvlStg")?.Element("to")?.Element("orbit");

            if (market is not null)
            {
                marketReader.Value.Read(market, data);
            }

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }
        }
    }
}
