using Microsoft.Extensions.Logging;
using SystemFinder.Abstractions.View;
using SystemFinder.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.View
{
    public class TreeViewPopulator(ILogger<TreeViewPopulator> logger) : ITreeViewPopulator
    {
        private readonly string[] _headlessSystems =
            [
                "Nullspace",
                "Deep Space",
                "Unknown Location",
                "Sea of Twilight",
                "Sea of Dreams",
                "Sea of Trust",
                "Sea of Decay",
                "Sea of Clouds",
                "Sea of Time",
                "Sea of Hope",
                "Sea of Hatred",
                "Sea of Sorrow",
                "Sea of Serenity",
                "Sea of Storms",
                "Sea of Tranquilility",
                "Sea of Luxury",
                "Sea of Epidemics",
            ];

        public List<TreeNode> BuildNodes(GalaxyData data)
        {
            logger.Log(LogLevel.Debug, "Building the Galaxy TreeNodes for display ...");

            var nodes = new List<TreeNode>();

            var systems = data.StarSystems.Values
                .OrderBy(x => _headlessSystems.Contains(x.Name) ? 1 : 0)
                .ThenBy(x => x.Name);

            foreach (var starSystem in systems!)
            {
                TreeNode system = new TreeNode(starSystem.Name, (int)TreeViewIconIndexes.StarSystem, (int)TreeViewIconIndexes.StarSystem);

                //find children for the star system
                FindAndAttachStars(data, starSystem, system);
                FindAndAttachGates(data, starSystem, system);
                FindAndAttachPlanets(data, starSystem, system);

                nodes.Add(system);
            }

            //Exception case: add free-floating gate(s) (See: Abyssal Gate)
            var hyperspaceGates = data.Gates.Values
                .Where(g => g.StarSystemId is null);

            foreach (var gate in hyperspaceGates!)
            {
                var gateIcon = (int)(gate.Scanned ? TreeViewIconIndexes.GateActive : TreeViewIconIndexes.GateInactive);
                TreeNode gateNode = new TreeNode(gate.Name, gateIcon, gateIcon);

                nodes.Add(gateNode);
            }

            var groupedPlanets = data.Planets.Values.GroupBy(x => x.StarSystemId);
            var joinSystems = groupedPlanets.Select(x =>
            {
                var system = data.StarSystems.SingleOrDefault(y => y.Value.Id == x.Key).Value.Name;
                return  new { System = system, Count = x.Count() };
            });
            var sortedSystems = joinSystems.OrderByDescending(ss => ss.Count).ThenBy(ss => ss.System);


            var inactiveGateSystems = data.Gates.Values.Where(g => !g.Scanned);
            var joinGateSystems = inactiveGateSystems.Select(x =>
            {
                var system = data.StarSystems.SingleOrDefault(y => y.Value.Id == x.StarSystemId).Value?.Name ?? x.Name;
                return system;
            });
            var sortedGates = joinGateSystems.OrderBy(gs => gs);

            return nodes;
        }

        private static void FindAndAttachStars(GalaxyData data, StarSystem starSystem, TreeNode system)
        {
            var stars = data.Stars.Values.Where(star => star.StarSystemId == starSystem.Id);
            if (stars.Any())
            {
                foreach (var star in stars)
                {
                    TreeNode starNode = new TreeNode(star.Name, (int)TreeViewIconIndexes.Star, (int)TreeViewIconIndexes.Star);
                    system.Nodes.Add(starNode);
                }
            }
        }

        private static void FindAndAttachGates(GalaxyData data, StarSystem starSystem, TreeNode system)
        {
            var gates = data.Gates.Values.Where(gate => gate.StarSystemId == starSystem.Id);
            if (gates.Any())
            {
                foreach (var gate in gates)
                {
                    var gateIcon = (int)(gate.Scanned ? TreeViewIconIndexes.GateActive : TreeViewIconIndexes.GateInactive);
                    TreeNode gateNode = new TreeNode(gate.Name, gateIcon, gateIcon);
                    system.Nodes.Add(gateNode);
                }
            }
        }

        private static void FindAndAttachPlanets(GalaxyData data, StarSystem starSystem, TreeNode system)
        {
            var planets = data.Planets.Values.Where(planet => planet.StarSystemId == starSystem.Id);
            if (planets.Any())
            {
                foreach (var planet in planets)
                {
                    TreeNode planetNode = new TreeNode(planet.Name, (int)TreeViewIconIndexes.Planet, (int)TreeViewIconIndexes.Planet);
                    system.Nodes.Add(planetNode);
                }
            }
        }
    }
}
