using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using SystemFinder.Logic.CampaignIO.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class CampaignEngineReader(ILogger<CampaignEngineReader> logger, IHyperspaceReader hyperspaceReader,
        IStarSystemsReader starSystemsReader)
        : ICampaignEngineReader
    {
        public void Read(XDocument root, GalaxyData data)
        {
            var campaign = root.Element("CampaignEngine")!;

            var hyperspace = campaign.Element("hyperspace");
            var starSystems = campaign.Element("starSystems");

            if (hyperspace is not null)
            {
                hyperspaceReader.Read(hyperspace, data);
            }

            if (starSystems is not null)
            {
                var expectedCount = starSystems.Elements()?.Count();
                logger.Log(LogLevel.Debug, $"Expected system count: {expectedCount}");
                starSystemsReader.Read(starSystems, data);
            }
        }
    }
}
