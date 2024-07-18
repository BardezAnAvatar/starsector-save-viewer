using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class EconomyReader(ILogger<EconomyReader> logger, Lazy<IMarketReader> marketReader) : IEconomyReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

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
                    marketReader.Value.Read(element, data);
                }
            }
        }
    }
}
