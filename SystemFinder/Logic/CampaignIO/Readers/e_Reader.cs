using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class e_Reader(ILogger<e_Reader> logger, IGenesisStationIntelReader genesisReader,
        Lazy<IMarketReader> marketReader, IOfficerManagerEventReader officerReader,
        IPlanetaryShieldIntelReader planetaryShieldIntelReader,  IRtSegReader rtSegReader,
        IWarSimScriptReader warSimScriptReader)
        : Ie_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var genesis = current.Element("kentington.diyplanets.GenesisStationIntel");
            var market = current.Element("Market");
            var officerManagerEvent = current.Element("OfficerManagerEvent");
            var rtSegs = current.Elements("rtSegReader");
            var warSimScript = current.Element("WarSimScript");
            var planetaryShieldIntel = current.Element("com.fs.starfarer.api.impl.campaign.intel.bar.events.PlanetaryShieldIntel");

            if (genesis is not null)
            {
                genesisReader.Read(genesis, data);
            }

            if (market is not null)
            {
                marketReader.Value.Read(market, data);
            }

            if (officerManagerEvent is not null)
            {
                officerReader.Read(officerManagerEvent, data);
            }

            if (rtSegs is not null && rtSegs.Any())
            {
                foreach (var element in rtSegs)
                {
                    rtSegReader.Read(element, data);
                }
            }

            if (warSimScript is not null)
            {
                warSimScriptReader.Read(warSimScript, data);
            }

            if (planetaryShieldIntel is not null)
            {
                planetaryShieldIntelReader.Read(planetaryShieldIntel, data);
            }
        }
    }
}
