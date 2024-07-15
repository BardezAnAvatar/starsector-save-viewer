using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class HyperspaceReader(SavedObjectReader osavedReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var o = current.Element("o");

            if (o is not null)
            {
                osavedReader.Read(o, data);
            }
        }
    }
}
