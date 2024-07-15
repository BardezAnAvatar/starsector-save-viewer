using System.Numerics;

namespace SystemFinder.Model
{
    internal class StarSystem
    {
        public string Ref { get; init; } = string.Empty;

        public List<Planet> Planets { get; init; } = [];

        public string Name { get; init; } = string.Empty;

        public Vector2 Position { get; init; }
    }
}
