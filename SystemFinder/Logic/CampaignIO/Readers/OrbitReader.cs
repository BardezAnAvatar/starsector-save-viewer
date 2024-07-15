using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OrbitReader(Is_Reader sReader, If_Reader fReader) : IOrbitReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var s = current.Element("s");
            var f = current.Element("f");

            if (s is not null)
            {
                sReader.Read(s, data);
            }

            if (f is not null)
            {
                fReader.Read(f, data);
            }
        }
    }
}
