using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class m_Reader(e_Reader eReader, PrimaryEntityReader primaryEntityReader) : Im_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var e = current
                .Element("d")
                ?.Elements("e");
            var primaryEntity = current.Element("primaryEntity");

            if (e is not null && e.Any())
            {
                foreach (var element in e)
                {
                    eReader.Read(element, data);
                }
            }

            if (primaryEntity is not null)
            {
                primaryEntityReader.Read(primaryEntity, data);
            }
        }
    }
}
