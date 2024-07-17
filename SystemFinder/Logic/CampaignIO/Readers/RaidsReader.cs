using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class RaidsReader(ILogger<RaidsReader> logger, IStagesReader stagesReader) : IRaidsReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var stages = current
                .Element("raids")
                ?.Element("NexRaidIntl")
                ?.Element("stages")
                ;

            if (stages is not null)
            {
                stagesReader.Read(stages, data);
            }
        }
    }
}
