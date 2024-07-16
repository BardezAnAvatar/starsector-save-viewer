using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class RtSegReader(If_Reader fReader, It_Reader tReader) : IRtSegReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var t = current.Element("t");
            var f = current.Element("f");

            if (t is not null)
            {
                tReader.Read(t, data);
            }

            if (f is not null)
            {
                fReader.Read(f, data);
            }
        }
    }
}
