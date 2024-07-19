namespace SystemFinder.Model
{
    public class StarSystem
    {
        public string Id { get; init; } = string.Empty;

        public string Name { get; init; } = string.Empty;

        public override string ToString() => $"{{ Name: {Name}; Id: {Id} }}";
    }
}
