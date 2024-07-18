using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommDirectoryEntryReader(ILogger<CommDirectoryEntryReader> logger, IEntryDataReader entryDataReader)
        : ICommDirectoryEntryReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var entryData = current
                .Element("entryData")
                ;

            if (entryData is not null)
            {
                entryDataReader.Read(entryData, data);
            }
        }
    }
}
