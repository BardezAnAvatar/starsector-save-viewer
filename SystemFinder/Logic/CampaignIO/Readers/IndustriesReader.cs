using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class IndustriesReader(ICryosanctumReader cryosanctumReader, IOrbitalStationReader orbitalStationReader)
        : IIndustriesReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var cryosanctum = current
                .Element("boggled.campaign.econ.industries.Boggled__Cryosanctum");

            var orbitalStation = current
                .Element("OrbitalStation");

            if (cryosanctum is not null)
            {
                cryosanctumReader.Read(cryosanctum, data);
            }

            if (orbitalStation is not null)
            {
                orbitalStationReader.Read(orbitalStation, data);
            }
        }
    }
}
