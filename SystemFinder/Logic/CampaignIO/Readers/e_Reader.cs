using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class e_Reader(ILogger<e_Reader> logger, IAbyssDataReader abyssDataReader,
        IGenesisStationIntelReader genesisReader, Lazy<IMarketReader> marketReader,
        IOfficerManagerEventReader officerReader, IPlanetaryShieldIntelReader planetaryShieldIntelReader,
        IRtSegReader rtSegReader, IWarSimScriptReader warSimScriptReader)
        : Ie_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var abyssData = current.Element("assortment__of__things.abyss.procgen.AbyssData");
            var planetaryShieldIntel = current.Element("com.fs.starfarer.api.impl.campaign.intel.bar.events.PlanetaryShieldIntel");
            var genesis = current.Element("kentington.diyplanets.GenesisStationIntel");
            var market = current.Element("Market");
            var officerManagerEvent = current.Element("OfficerManagerEvent");
            var rtSegs = current.Elements("RtSeg");
            var warSimScript = current.Element("WarSimScript");

            if (abyssData is not null)
            {
                abyssDataReader.Read(abyssData, data);
            }

            if (planetaryShieldIntel is not null)
            {
                planetaryShieldIntelReader.Read(planetaryShieldIntel, data);
            }

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
        }
    }
}
