using System.Drawing;
using System.IO;
using System.Reflection.Metadata;
using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class OrbitReader(SavedObjectReader sReader, F_Reader fReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var s = current.Element("s");
            var f = current.Element("f");

            if (s != null)
            {
                sReader.Read(s, data);
            }

            if (f != null)
            {
                fReader.Read(f, data);
            }
        }
    }
}
