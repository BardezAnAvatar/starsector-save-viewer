using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class IndustriesReader(ICryosanctumReader cryosanctumReader) : IIndustriesReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var cryosanctum = current
                .Element("boggled.campaign.econ.industries.Boggled__Cryosanctum");

            if (cryosanctum is not null)
            {
                cryosanctumReader.Read(cryosanctum, data);
            }
        }
    }
}
