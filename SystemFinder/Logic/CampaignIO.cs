using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using SystemFinder.Model;

namespace SystemFinder.Logic
{
    internal class CampaignIO
    {
        public static List<StarSystem> ReadSave(Stream file)
        {
            XDocument root = XDocument.Load(file);

            //TODO: Code
            var systems = GetSystems(root);

            return [];
        }

        private static List<StarSystem> GetSystems(XDocument root)
        {
            var systems = new List<StarSystem>();

            var campaign = root.Element("CampaignEngine")!;

            var hyperspace = campaign.Element("hyperspace")!;

            var starSystems = campaign.Element("starSystems")!;

            foreach (var system in starSystems.Elements())
            {
                systems.Add(ReadSystemDetails(system!, hyperspace));
            }

            return systems;
        }

        private static StarSystem ReadSystemDetails(XElement starSystem, XElement hyperspace)
        {
            var systemRefId = starSystem.Attribute("ref")!;

            //Get the whacky systems location:

            var saved = //?
                hyperspace
                .Element("o")!
                .Element("saved")!
                .Elements("LocationToken")!
                .First()
                .Element("orbit")!
                .Element("s")!
                .Element("o")!      //notice something recursive here?
                .Element("saved")!
                ;

            if (TrySavedMarket(saved, systemRefId.Value, out var marketSystem))
            {
                return marketSystem!;
            }

            //NOTE: locationTokens have a count of N-1 compared to starSystems' elements. hmm...

            return new StarSystem();
        }

        private static bool TrySavedMarket(XElement saved, string systemRef, out StarSystem? foundSystem)
        {
            bool found = false;
            foundSystem = null;

            var markets = saved
                .Elements("CCEnt")!
                .Skip(1).First() // [2]
                                 //./market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/
                .Element("market")!
                .Element("economy")!
                .Element("stepper")!
                .Element("econ")!
                .Element("markets")!
                ;

            if (TrySavedMarkets(markets, systemRef, out var marketSystem))
            {
                foundSystem = marketSystem!;
                found = true;
            }

            return found;
        }

        private static bool TrySavedMarkets(XElement markets, string systemRef, out StarSystem? foundSystem)
        {
            bool found = false;
            foundSystem = null;

            var saved = markets
                .Elements("Market")!
                .Skip(1).First() // [2]
                                 //./Market[2]/primaryEntity/orbit/f/cL/o/saved/
                .Element("primaryEntity")!
                .Element("orbit")!
                .Element("f")!
                .Element("cL")!
                .Element("o")!
                .Element("saved")!
                ;

            if (TryMarketsDestination(markets, systemRef, out var marketSystem))
            {
                foundSystem = marketSystem!;
                found = true;
            }

            return found;
        }

        private static bool TryMarketsDestination(XElement saved, string systemRef, out StarSystem? foundSystem)
        {
            bool found = false;
            foundSystem = null;

            var market = saved
                .Elements("CCEnt")!
                .Skip(3).First() // [4]
                .Element("market")!
                ;

            if (TrySavedMarket(market, systemRef, out var marketSystem))
            {
                foundSystem = marketSystem!;
                found = true;
            }

            return found;
        }

        // ./commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL
        private static bool TryCommDirectory(XElement market, string systemRef, out StarSystem? foundSystem)
        {
            bool found = false;
            foundSystem = null;

            // //person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL
            var cL = market
                // ./commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d
                .Element("commDirectory")!
                .Element("entries")!
                .Elements("CommDirectoryEntry")!
                .Skip(4).First() // [5]
                .Element("entryData")!
                .Element("m")!
                .Element("d")!

                // ./e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/
                .Elements("e")!
                .Skip(3).First() // [4]
                .Element("OfficerManagerEvent")!
                .Element("available")!
                .Elements("AvailableOfficer")!
                .Skip(2).First() // [3]
                .Element("person")!
                .Element("market")!
                .Element("industries")!

                // ./boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/
                .Element("boggled.campaign.econ.industries.Boggled__Cryosanctum")!
                .Element("thisIndustry")!
                .Element("ctx")!
                .Element("fleet")!
                .Element("cL")!
                .Element("o")!
                .Element("saved")!
                .Elements("Flt")!
                .Skip(2).First() // [3]

                // ./dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL
                .Element("dL")!
                .Element("RouteManager")!
                .Element("r")!
                .Elements("RouteData")!
                .Skip(184).First() // [185]
                .Element("m")!
                .Element("primaryEntity")!
                .Element("orbit")!
                .Element("f")!
                .Element("cL")!
                ;

            if (TryMarketsDestinationCL(cL, systemRef, out var marketSystem))
            {
                foundSystem = marketSystem!;
                found = true;
            }

            return found;
        }

        private static bool TryMarketsDestinationCL(XElement cL, string systemRef, out StarSystem? foundSystem)
        {
            bool found = false;
            foundSystem = null;

            var name = cL
                .Attribute("bN")!.Value;

            var system = cL
                .Elements("CCEnt")!
                .Skip(3).First() // [4]
                .Element("market")!
                ;

            found = true;

            foundSystem = new StarSystem
            {
                Name = name,
                Ref = systemRef,
                Position = new System.Numerics.Vector2(0, 0),
            };


            return found;
        }
    }
}
