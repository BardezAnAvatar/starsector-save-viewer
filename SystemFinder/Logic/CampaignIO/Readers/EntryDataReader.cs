using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class EntryDataReader(Im_Reader mReader, IStatsReader statsReader) : IEntryDataReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var stats =
                current
                .Element("stats")
                ;

            var m =
                current
                .Element("m")
                ;

            if (stats is not null)
            {
                statsReader.Read(stats, data);
            }

            if (m is not null)
            {
                mReader.Read(m, data);
            }
        }
    }
}
