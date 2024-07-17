using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ScriptReader(ILogger<ScriptReader> logger, Ie_Reader eReader) : IScriptReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

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

            if (e is not null && e.Any())
            {
                foreach (var element in e)
                {
                    eReader.Read(element, data);
                }
            }
        }
    }
}
