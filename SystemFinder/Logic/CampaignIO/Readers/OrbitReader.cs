using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Model;

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
    public Orbit? Read(XElement current, string xPath)
    {
        logger.Log(LogLevel.Information, $"Reading orbit for: {xPath}");

        Orbit? orbit = null;

        var orbitNode = current
            .Elements("orbit")
            ?.Where(o => o?.Attribute("cl")?.Value is not null && o?.Elements()?.Count() == 2)
            .SingleOrDefault();

        if (orbitNode != null)
        {
            var radius = ExtractRadius(orbitNode);
            var orbitParentId = ExtractOrbitParentId(orbitNode);
            orbit = new()
            {
                ParentId = orbitParentId,
                Radius = radius,
            };
        }

        return orbit;

        //throw new GateParsingException($"Could not locate parent orbit body reference for `{name}`; xPath `{xPath}`");
    }

    private static decimal? ExtractRadius(XElement orbitNode)
    {
        decimal? radius = null;

        var radiusValue = orbitNode.Attribute("r")?.Value;
        if (Decimal.TryParse(radiusValue, out decimal r))
        {
            radius = r;
        }

        return radius;
    }

    private static string? ExtractOrbitParentId(XElement orbitNode)
    {
        string? uuid = null;

        var orbitParent = orbitNode
            ?.Elements()
            ?.Skip(1)
            ?.SingleOrDefault()
            ;

        if (orbitParent is not null)
        {
            //could be a definition or a reference
            uuid = orbitParent.Attribute("z")?.Value ?? orbitParent.Attribute("ref")?.Value;
        }

        return uuid;
    }
}
