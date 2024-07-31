using System.Xml.Linq;
using Microsoft.Extensions.Logging;

namespace SystemFinder.Logic.CampaignIO.Readers;

public class OrbitReader(ILogger<OrbitReader> logger) : IOrbitReader
{
    /// <remarks>
    ///     There appear to be three kinds of orbits:
    ///     cl="CircularFleetOrbit" has 7 nodes
    ///     cl="UpdateFromSystemLocationOrbit" has 6 nodes
    ///     everything else appears to have 2 nodes:
    ///         a hierarchy of one node being self, followed the next, its parent
    /// </remarks>
    public string? ExtractOrbitReference(XElement current, string xPath)
    {
        logger.Log(LogLevel.Information, $"Reading orbit for: {xPath}");

        string? uid = null;

        var orbitParent = current
            .Elements("orbit")
            ?.Where(o => o?.Attribute("cl")?.Value is not null && o?.Elements()?.Count() == 2)
            ?.Elements()
            ?.Skip(1)
            ?.SingleOrDefault()
            ;

        if (orbitParent is not null)
        {
            //could be a definition or a reference
            uid = orbitParent.Attribute("z")?.Value ?? orbitParent.Attribute("ref")?.Value;
        }

        return uid;

        //throw new GateParsingException($"Could not locate parent orbit body reference for `{name}`; xPath `{xPath}`");
    }
}
