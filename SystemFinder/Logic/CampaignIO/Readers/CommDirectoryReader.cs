using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommDirectoryReader(ILogger<CommDirectoryReader> logger,
        ICommDirectoryEntryReader commDirectoryEntryReader) : ICommDirectoryReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var commDirectoryEntries = current
                .Element("entries")
                ?.Elements("CommDirectoryEntry")
                ;

            if (commDirectoryEntries is not null && commDirectoryEntries.Any())
            {
                foreach (var element in commDirectoryEntries)
                {
                    commDirectoryEntryReader.Read(element, data);
                }
            }
        }
    }
}
