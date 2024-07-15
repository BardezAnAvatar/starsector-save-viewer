using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class f_Reader(OrbitReader orbitReader, cL_Reader clReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var cL = current.Element("cL");
            var orbit = current.Element("orbit");

            if (cL is not null)
            {
                clReader.Read(cL, data);
            }

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }
        }
    }
}
