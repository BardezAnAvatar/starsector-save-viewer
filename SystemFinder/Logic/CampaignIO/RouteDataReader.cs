using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class RouteDataReader(e_Reader eReader, m_Reader mReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var e = current.Element("e");
            var m = current.Element("m");

            if (e is not null)
            {
                eReader.Read(e, data);
            }

            if (m is not null)
            {
                mReader.Read(m, data);
            }
        }
    }
}
