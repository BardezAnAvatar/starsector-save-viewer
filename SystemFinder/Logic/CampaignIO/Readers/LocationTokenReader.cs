using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class LocationTokenReader(OrbitReader orbitReader) : ILocationTokenReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var orbit = current.Element("orbit");

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }
        }
    }
}
