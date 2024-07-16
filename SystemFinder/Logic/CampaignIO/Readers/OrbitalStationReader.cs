using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OrbitalStationReader(IdL_Reader dlReader) : IOrbitalStationReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var dl = current
                .Element("sf")
                ?.Element("dL")
                ;

            if (dl is not null)
            {
                dlReader.Read(dl, data);
            }
        }
    }
}
