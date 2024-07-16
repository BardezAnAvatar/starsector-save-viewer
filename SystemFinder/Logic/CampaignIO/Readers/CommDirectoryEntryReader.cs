using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommDirectoryEntryReader(IEntryDataReader entryDataReader) : ICommDirectoryEntryReader
    {
        public void Read(XElement current, GalaxyData data)
        {
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
