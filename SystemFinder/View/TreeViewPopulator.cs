using Microsoft.Extensions.Logging;
using SystemFinder.Abstractions.View;
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

            foreach (var starSystem in systems)
            {
                TreeNode system = new TreeNode(starSystem.Name, (int)TreeViewIconIndexes.StarSystem, (int)TreeViewIconIndexes.StarSystem);

                //find children for the star system
                var stars = data.Stars.Values.Where(star => star.StarSystemId == starSystem.Id);
                if (stars.Any())
                {
                    foreach (var star in stars)
                    {
                        TreeNode starNode = new TreeNode(star.Name, (int)TreeViewIconIndexes.Star, (int)TreeViewIconIndexes.Star);
                        system.Nodes.Add(starNode);
                    }
                }

                nodes.Add(system);
            }

            return nodes;
        }
    }
}
