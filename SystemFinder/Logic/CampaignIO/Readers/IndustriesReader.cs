using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class IndustriesReader(ILogger<IndustriesReader> logger, ICryosanctumReader cryosanctumReader,
        IOrbitalStationReader orbitalStationReader)
        : IIndustriesReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

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
