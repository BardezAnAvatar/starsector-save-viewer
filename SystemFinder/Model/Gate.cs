namespace SystemFinder.Model
{
    public class Gate
    {
        public string Id { get; init; } = string.Empty;

        public string? StarSystemId { get; init; } = string.Empty;

        public string Name { get; init; } = string.Empty;

        public bool Scanned { get; init; } = default;

        public override string ToString() => $"{{ Name: {Name}; Id: {Id}; StarSystemId: {StarSystemId ?? "null"}; Scanned: {Scanned} }}";
    }
}
