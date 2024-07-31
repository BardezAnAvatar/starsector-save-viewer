using System.Text.Json.Nodes;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Abstractions.Logic.CampaignIO.Readers;
using SystemFinder.Exceptions;
using SystemFinder.Model;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers.Model
{
    public class StarReader(ILogger<StarReader> logger, IOrbitReader orbitReader) : IStarReader
    {
        public void Read(XElement current, XAttribute uid, GalaxyData data)
        {
            var xPath = current.GetAbsoluteXPath();
            logger.Log(LogLevel.Information, $"Reading Star: {xPath}");

            //NOTE: Be careful of duplication. Seems some things duplicate with mods, etc.
            if (!data.Stars.ContainsKey(uid.Value))
            {
                var name = ExtractStarName(current, xPath);
                var systemId = ExtractStarSystemReference(current, xPath);
                var orbit = orbitReader.Read(current, xPath);

                var star = new Star
                {
                    Id = uid.Value,
                    Name = name,
                    StarSystemId = systemId,
                    Orbit = orbit,
                };

                data.Stars.Add(uid.Value, star);
            }
        }

        private string ExtractStarName(XElement current, string xPath)
        {
            string name = string.Empty;
            var json = current.Element("j0");
            if (json != null)
            {
                var jObject = JsonObject.Parse(json.Value);
                var f0 = jObject?["f0"];
                if (f0 is not null)
                {
                    return f0.GetValue<string>();
                }
            }

            throw new StarParsingException($"Could not locate star name for node `{xPath}`");
        }

        private string ExtractStarSystemReference(XElement current, string xPath)
        {
            var sstm = current
                .Elements()
                .Where(e => e.Attribute("cl")?.Value == "Sstm")
                .SingleOrDefault();

            if (sstm is not null)
            {
                //could be a definition or a reference
                var uid = sstm.Attribute("z")?.Value ?? sstm.Attribute("ref")?.Value;
                if (uid is not null)
                {
                    return uid;
                }
            }

            throw new StarParsingException($"Could not locate star name for node `{xPath}`");
        }
    }
}
