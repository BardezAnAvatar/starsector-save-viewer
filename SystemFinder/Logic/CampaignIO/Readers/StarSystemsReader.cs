using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class StarSystemsReader(ISstmReader sstmReader) : IStarSystemsReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var sstm = current.Elements("Sstm");

            if (sstm != null && sstm.Any())
            {
                foreach (var element in sstm)
                {
                    sstmReader.Read(element, data);
                }
            }
        }
    }
}
