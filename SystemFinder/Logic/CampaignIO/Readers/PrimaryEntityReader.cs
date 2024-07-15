using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PrimaryEntityReader(OrbitReader orbitReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var orbit = current
                .Element("orbit")
                ;

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }
        }
    }
}
