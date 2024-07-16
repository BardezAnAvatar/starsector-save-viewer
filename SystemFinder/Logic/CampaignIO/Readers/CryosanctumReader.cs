using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CryosanctumReader(IFleetReader fleetReader) : ICryosanctumReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var fleet = current
                .Element("thisIndustry")
                ?.Element("ctx")
                ?.Element("fleet")
                ;

            if (fleet is not null)
            {
                fleetReader.Read(fleet, data);
            }
        }
    }
}
