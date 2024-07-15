using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class GenesisStationIntelReader(PrimaryEntityReader primaryEntityReader) : IGenesisStationIntelReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var primaryEntity = current
                .Element("event")
                ?.Element("shownAt")
                ?.Element("primaryEntity")
                ;

            if (primaryEntity is not null)
            {
                primaryEntityReader.Read(primaryEntity, data);
            }
        }
    }
}
