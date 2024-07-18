using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ScriptReader(ILogger<ScriptReader> logger, Lazy<Ie_Reader> eReader,
        IResearchFleetRouteManagerReader researchFleetRouteManagerReader) : IScriptReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var dataResearchFleetRouteManager = current.Element("data.kaysaar.aotd.vok.scripts.research.ResearchFleetRouteManager");
            var e = current
                .Element("MissionFleetAutoDespawn")
                ?.Element("mission")
                ?.Element("triggers")
                ?.Element("MissionTrigger")
                ?.Element("actions")
                ?.Element("com.fs.starfarer.api.impl.campaign.missions.hub.HubMissionWithTriggers_-SetMemoryValueAction")
                ?.Element("memory")
                ?.Element("d")
                ?.Elements("e")
                ;

            if (dataResearchFleetRouteManager is not null)
            {
                researchFleetRouteManagerReader.Read(dataResearchFleetRouteManager, data);
            }

            if (e is not null && e.Any())
            {
                foreach (var element in e)
                {
                    eReader.Value.Read(element, data);
                }
            }
        }
    }
}
