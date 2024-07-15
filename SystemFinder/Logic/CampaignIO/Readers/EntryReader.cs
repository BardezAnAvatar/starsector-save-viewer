using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class EntryReader(FleetReader fleetReader, m_Reader mReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var fleet =
                current
                .Element("stats")
                ?.Element("fleet")
                ;

            var m =
                current
                .Element("m")
                ;

            if (fleet is not null)
            {
                fleetReader.Read(fleet, data);
            }

            if (m is not null)
            {
                mReader.Read(m, data);
            }
        }
    }
}
