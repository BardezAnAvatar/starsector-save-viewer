using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using SystemFinder.Logic.CampaignIO.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class CampaignEngineReader(ILogger<CampaignEngineReader> logger, Ie_Reader eReader,
        IHyperspaceReader hyperspaceReader,
        IStarSystemsReader starSystemsReader)
        : ICampaignEngineReader
    {
        public void Read(XDocument root, GalaxyData data)
        {
            var campaign = root.Element("CampaignEngine")!;

            var hyperspace = campaign.Element("hyperspace");
            var modE = campaign
                .Element("modAndPluginData")
                ?.Element("persistentData")
                ?.Elements("e");
            var starSystems = campaign.Element("starSystems");

            if (hyperspace is not null)
            {
                hyperspaceReader.Read(hyperspace, data);
            }

            if (modE is not null && modE.Any())
            {
                foreach (var element in modE)
                {
                    eReader.Read(element, data);
                }
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
