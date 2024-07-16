﻿using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class e_Reader(IGenesisStationIntelReader genesisReader, Lazy<IMarketReader> marketReader,
        IOfficerManagerEventReader officerReader, IPlanetaryShieldIntelReader planetaryShieldIntelReader, 
        IRtSegReader rtSegReader, IWarSimScriptReader warSimScriptReader)
        : Ie_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
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
