using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class AnalyzeEntityMissionIntelReader(ILogger<AnalyzeEntityMissionIntelReader> logger,
        IEntityReader entityReader) : IAnalyzeEntityMissionIntelReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var entity = current.Element("entity");

            if (entity is not null)
            {
                entityReader.Read(entity, data);
            }
        }
    }
}
