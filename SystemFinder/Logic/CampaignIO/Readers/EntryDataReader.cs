using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class EntryDataReader(ILogger<EntryDataReader> logger, Im_Reader mReader, IStatsReader statsReader)
        : IEntryDataReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var m = current.Element("m");
            var stats = current.Element("stats");

            if (m is not null)
            {
                mReader.Read(m, data);
            }

            if (stats is not null)
            {
                statsReader.Read(stats, data);
            }
        }
    }
}
