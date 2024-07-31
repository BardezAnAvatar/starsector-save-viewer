using Microsoft.Extensions.Logging;
using SystemFinder.Abstractions.View;
using SystemFinder.Model;
using SystemFinder.Model.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                FindAndAttachNonOrbitingStars(data, starSystem.Id, system);
                FindAndAttachNonOrbitingGates(data, starSystem.Id, system);
                FindAndAttachNonOrbitingPlanets(data, starSystem.Id, system);

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

        private static void AttachChildren(GalaxyData data, string parentId, TreeNode parentNode)
        {
            //find children for the star system
            FindAndAttachOrbitingStars(data, parentId, parentNode);
            FindAndAttachOrbitingGates(data, parentId, parentNode);
            FindAndAttachOrbitingPlanets(data, parentId, parentNode);
        }

        private static void FindAndAttachNonOrbitingStars(GalaxyData data, string parentId, TreeNode system)
        {
            var stars = data.Stars.Values.Where(star => star.StarSystemId == parentId && star.Orbit?.ParentId is null);
            if (stars.Any())
            {
                foreach (var star in stars)
                {
                    AttachStarNode(data, system, star);
                }
            }
        }

        private static void FindAndAttachOrbitingStars(GalaxyData data, string parentId, TreeNode system)
        {
            var stars = data.Stars.Values.Where(star => star.Orbit?.ParentId == parentId);
            if (stars.Any())
            {
                foreach (var star in stars)
                {
                    AttachStarNode(data, system, star);
                }
            }
        }

        private static void FindAndAttachNonOrbitingPlanets(GalaxyData data, string parentId, TreeNode system)
        {
            var planets = data.Planets.Values.Where(planet => planet.StarSystemId == parentId && planet.Orbit?.ParentId is null);
            if (planets.Any())
            {
                foreach (var planet in planets)
                {
                    AttachPlanetNode(data, system, planet);
                }
            }
        }

        private static void FindAndAttachOrbitingPlanets(GalaxyData data, string parentId, TreeNode system)
        {
            var planets = data.Planets.Values.Where(planet => planet.Orbit?.ParentId == parentId);
            if (planets.Any())
            {
                foreach (var planet in planets)
                {
                    AttachPlanetNode(data, system, planet);
                }
            }
        }

        private static void FindAndAttachOrbitingGates(GalaxyData data, string parentId, TreeNode system)
        {
            var gates = data.Gates.Values.Where(gate => gate.Orbit?.ParentId == parentId);
            if (gates.Any())
            {
                foreach (var gate in gates)
                {
                    AttachGateNode(data, system, gate);
                }
            }
        }

        private static void FindAndAttachNonOrbitingGates(GalaxyData data, string parentId, TreeNode system)
        {
            var gates = data.Gates.Values.Where(gate => gate.StarSystemId == parentId && gate.Orbit?.ParentId is null);
            if (gates.Any())
            {
                foreach (var gate in gates)
                {
                    AttachGateNode(data, system, gate);
                }
            }
        }

        private static void AttachStarNode(GalaxyData data, TreeNode system, Star star)
        {
            TreeNode starNode = new TreeNode(star.Name, (int)TreeViewIconIndexes.Star, (int)TreeViewIconIndexes.Star);

            //find children for the star
            AttachChildren(data, star.Id, starNode);

            system.Nodes.Add(starNode);
        }

        private static void AttachPlanetNode(GalaxyData data, TreeNode system, Planet planet)
        {
            TreeNode planetNode = new TreeNode(planet.Name, (int)TreeViewIconIndexes.Planet, (int)TreeViewIconIndexes.Planet);

            //find children for the planet
            AttachChildren(data, planet.Id, planetNode);

            system.Nodes.Add(planetNode);
        }

        private static void AttachGateNode(GalaxyData data, TreeNode system, Gate gate)
        {
            var gateIcon = (int)(gate.Scanned ? TreeViewIconIndexes.GateActive : TreeViewIconIndexes.GateInactive);
            TreeNode gateNode = new TreeNode(gate.Name, gateIcon, gateIcon);

            //find children for the gate
            AttachChildren(data, gate.Id, gateNode);

            system.Nodes.Add(gateNode);
        }
    }
}
