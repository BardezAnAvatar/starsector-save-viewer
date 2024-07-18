using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ActiveReader(ILogger<ActiveReader> logger,
        IAnalyzeEntityMissionIntelReader analyzeEntityMissionIntelReader,
        IPersonBountyIntelReader personBountyIntelReader)
        : IActiveReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var analyzeEntityMissionIntel = current.Elements("AnalyzeEntityMissionIntel");
            var personBountyIntel = current.Elements("PersonBountyIntel");

            if (analyzeEntityMissionIntel is not null && analyzeEntityMissionIntel.Any())
            {
                foreach (var element in analyzeEntityMissionIntel)
                {
                    analyzeEntityMissionIntelReader.Read(element, data);
                }
            }

            if (personBountyIntel is not null && personBountyIntel.Any())
            {
                foreach (var element in personBountyIntel)
                {
                    personBountyIntelReader.Read(element, data);
                }
            }
        }
    }
}
