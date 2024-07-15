using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class WarSimScriptReader(SstmReader systemReader) : IWarSimScriptReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var sstm = current
                .Element("queue")
                ?.Elements("Sstm")
                ;

            if (sstm is not null && sstm.Any())
            {
                foreach (var element in sstm)
                {
                    systemReader.Read(element, data);
                }
            }
        }
    }
}
