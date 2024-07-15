using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class f_Reader(IOrbitReader orbitReader, IcL_Reader clReader) : If_Reader
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
