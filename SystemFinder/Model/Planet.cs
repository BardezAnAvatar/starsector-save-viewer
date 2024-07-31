namespace SystemFinder.Model
{
    public class Planet
    {
        public string Id { get; init; } = string.Empty;

        public string StarSystemId { get; init; } = string.Empty;

        public Orbit? Orbit { get; init; } = null;

        public string Name { get; init; } = string.Empty;

        public bool Colonized { get; init; } = false;

        public string Surveyed { get; init; } = string.Empty;

        public int Size { get; init; } = 0;

        public List<string> Conditions { get; init; } = [];

        public override string ToString() => $"{{ Name: {Name}; Id: {Id}; StarSystemId: {StarSystemId}; Colonized: {Colonized} }}";
    }
}
