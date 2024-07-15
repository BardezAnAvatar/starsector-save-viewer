using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommDirectoryReader(EntryReader entryReader)
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
                    entryReader.Read(element, data);
                }
            }
        }
    }
}
