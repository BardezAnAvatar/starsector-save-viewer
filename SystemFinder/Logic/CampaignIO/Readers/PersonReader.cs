using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PersonReader(ILogger<PersonReader> logger, Lazy<IMarketReader> marketReader,
        IStatsReader statsReader) : IPersonReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var market = current.Element("market");
            var stats = current.Element("stats");

            if (market is not null)
            {
                marketReader.Value.Read(market, data);
            }

            if (stats is not null)
            {
                statsReader.Read(stats, data);
            }
        }
    }
}
