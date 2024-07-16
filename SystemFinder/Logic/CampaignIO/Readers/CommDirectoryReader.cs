using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommDirectoryReader(ICommDirectoryEntryReader commDirectoryEntryReader) : ICommDirectoryReader
    {
        public void Read(XElement current, GalaxyData data)
        {
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
