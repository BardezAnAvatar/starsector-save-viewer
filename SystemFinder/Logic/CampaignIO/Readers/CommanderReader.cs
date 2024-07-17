using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommanderReader(ILogger<CommanderReader> logger, IiT_Reader itReader, IStatsReader statsReader)
        : ICommanderReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var fliT = current.Element("fl")?.Element("iT");
            var stats = current.Element("stats");

            if (fliT is not null)
            {
                itReader.Read(fliT, data);
            }

            if (stats is not null)
            {
                statsReader.Read(stats, data);
            }
        }
    }
}
