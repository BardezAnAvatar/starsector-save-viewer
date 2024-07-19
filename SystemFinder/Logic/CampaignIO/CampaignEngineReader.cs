using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Abstractions.Logic.CampaignIO;
using SystemFinder.Abstractions.Logic.CampaignIO.Readers;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class CampaignEngineReader(ILogger<CampaignEngineReader> logger, IGateReader gateReader,
        IStarReader starReader, IStarSystemReader starSystemReader)
        : ICampaignEngineReader
    {
        public void Read(XDocument root, GalaxyData data)
        {
            FindSystems(root, data);
            FindStars(root, data);
            FindGates(root, data);
        }

        public void FindSystems(XDocument root, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, "Counting expected Systems ...");
            var sanityCheckSystemCount = root.Element("CampaignEngine")?.Element("starSystems")?.Elements("Sstm")?.Count() ?? 0;
            logger.Log(LogLevel.Debug, $"Expecting {sanityCheckSystemCount} Systems");

            logger.Log(LogLevel.Debug, "Searching for `Sstm` Systems ...");
            var sstm = root
                .Descendants("Sstm")
                ?.Where(e => e.Attribute("z") is not null);

            logger.Log(LogLevel.Debug, "Searching for Non-`Sstm` Systems ...");
            var filter = root
                .Descendants()
                ?.Where(d => d.Attribute("z") is not null && d.Attribute("cl")?.Value == "Sstm");

            logger.Log(LogLevel.Debug, "Parsing `Sstm` Systems ...");
            if (sstm is not null && sstm.Any())
            {
                foreach (var element in sstm)
                {
                    var uid = element.Attribute("z")!;  //already established above (line 25)
                    starSystemReader.Read(element, uid, data);
                }
            }

            logger.Log(LogLevel.Debug, "Parsing Non-`Sstm` Systems ...");
            if (filter is not null && filter.Any())
            {
                foreach (var element in filter)
                {
                    var uid = element.Attribute("z")!;  //already established above (line 25)
                    starSystemReader.Read(element, uid, data);
                }
            }

            //exception if we don't have matching counts?
            if (data.StarSystems.Count() < sanityCheckSystemCount)
            {
                throw new ApplicationException($"Expected at least {sanityCheckSystemCount} star systems, but found {data.StarSystems.Count()}.");
            }
        }

        public void FindStars(XDocument root, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, "Counting expected Systems ...");
            var sanityCheckSystemCount = root.Element("CampaignEngine")?.Element("starSystems")?.Elements("Sstm")?.Count() ?? 0;
            logger.Log(LogLevel.Debug, $"Expecting {sanityCheckSystemCount} Systems");

            logger.Log(LogLevel.Debug, "Searching for Stars ...");
            var stars = root
                .Descendants()
                //planets
                .Where(d =>
                {
                    //Stars are Planets because of course
                    var planet = d.Name == "Plnt" && d.Attribute("z") is not null;
                    var nonPlanet = d.Attribute("cl")?.Value == "Plnt" && d.Attribute("z") is not null;

                    return planet || nonPlanet;
                })
                //type == star
                .Where(d =>
                {
                    var star = false;
                    var tags = d.Element("tags");
                    if (tags is not null)
                    {
                        var st = tags.Elements("st");
                        star = (st is not null && st.Any(tag => tag.Value == "star"));
                    }

                    return star;
                });

            var starCount = stars?.Count() ?? 0;

            logger.Log(LogLevel.Debug, "Parsing Stars ...");
            if (stars is not null && stars.Any())
            {
                foreach (var element in stars)
                {
                    var uid = element.Attribute("z")!;  //already established above (line 25)
                    starReader.Read(element, uid, data);
                }
            }

            /*
            //exception if we don't have matching counts?
            if (data.Stars.Count() < sanityCheckSystemCount)
            {
                throw new StarParsingException($"Expected at least {sanityCheckSystemCount} stars, but found {data.Stars.Count()}.");
            }
            */

            var sorted = data.Stars
                .OrderBy(x => x.Value.ToString());
            var missingStars = data.StarSystems
                .Where(
                    ss => data.Stars
                        .Where(s => s.Value.StarSystemId == ss.Key)
                        .Count() == 0
                )
                .Select(kvp => kvp.Value);
        }

        public void FindGates(XDocument root, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, "Counting expected Systems ...");
            var sanityCheckSystemCount = root.Element("CampaignEngine")?.Element("starSystems")?.Elements("Sstm")?.Count() ?? 0;
            logger.Log(LogLevel.Debug, $"Expecting {sanityCheckSystemCount} Systems");

            logger.Log(LogLevel.Debug, "Searching for Gates ...");
            var gates = root
                .Descendants()
                //stations
                .Where(d =>
                {
                    var station = d.Attribute("fL")?.Value == "STATIONS" && d.Attribute("z") is not null;

                    return station;
                })
                //type == gate
                .Where(d =>
                {
                    var gate = false;
                    var tags = d.Element("tags");
                    if (tags is not null)
                    {
                        var st = tags.Elements("st");
                        gate = (st is not null && st.Any(tag => tag.Value == "gate"));
                    }

                    return gate;
                });

            var gateCount = gates?.Count() ?? 0;

            logger.Log(LogLevel.Debug, "Parsing Gates ...");
            if (gates is not null && gates.Any())
            {
                foreach (var element in gates)
                {
                    var uid = element.Attribute("z")!;  //already established above (line 25)
                    gateReader.Read(element, uid, data);
                }
            }

            /*
            //exception if we don't have matching counts?
            if (data.Gates.Count() >= sanityCheckSystemCount)
            {
                throw new StarParsingException($"Expected fewer than {sanityCheckSystemCount} gates, but found {data.Gates.Count()}.");
            }
            */

            var sorted = data.Gates
                .OrderBy(x => x.Value.ToString());
            var missingGates = data.StarSystems
                .Where(
                    ss => data.Gates
                        .Where(s => s.Value.StarSystemId == ss.Key)
                        .Count() == 0
                )
                .Select(kvp => kvp.Value);
        }
    }
}
