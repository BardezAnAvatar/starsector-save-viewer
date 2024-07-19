namespace SystemFinder.Model.Data
{
    public class GalaxyData
    {
        public Dictionary<string, Planet> Planets { get; init; } = new();
        public Dictionary<string, StarSystem> StarSystems { get; init; } = new();
        public Dictionary<string, Star> Stars { get; init; } = new();
        public Dictionary<string, Fleet> Fleets { get; init; } = new();
        public Dictionary<string, Station> Stations { get; init; } = new();
        public Dictionary<string, Gate> Gates { get; init; } = new();
    }
}
