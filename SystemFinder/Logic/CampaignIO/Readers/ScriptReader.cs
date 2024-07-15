using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ScriptReader(e_Reader eReader) : IScriptReader
    {
        public void Read(XElement current, GalaxyData data)
        {
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
