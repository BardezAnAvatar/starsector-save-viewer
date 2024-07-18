using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class CampaignEngineReader(ILogger<CampaignEngineReader> logger, IStarSystemReader starSystemReader)
        : ICampaignEngineReader
    {
        public void Read(XDocument root, GalaxyData data)
        {
            FindSystems(root, data);
        }

        public void FindSystems(XDocument root, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, "Counting expected Systems ...");
            var sanityCheckSystemCount = root.Element("CampaignEngine")?.Element("starSystems")?.Elements("Sstm")?.Count() ?? 0;
            logger.Log(LogLevel.Debug, $"Expecting {sanityCheckSystemCount} Systems!");

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
    }
}
