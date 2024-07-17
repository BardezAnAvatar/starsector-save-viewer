using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommanderReader(ILogger<CommanderReader> logger, IStatsReader statsReader) : ICommanderReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var stats = current.Element("stats");

            if (stats is not null)
            {
                statsReader.Read(stats, data);
            }
        }
    }
}
