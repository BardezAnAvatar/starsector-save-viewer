using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PlanetReader(ILogger<PlanetReader> logger, Lazy<IMarketReader> marketReader) : IPlanetReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var market = current.Element("market");

            if (market is not null)
            {
                marketReader.Value.Read(market, data);
            }
        }
    }
}
