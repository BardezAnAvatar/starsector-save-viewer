namespace SystemFinder.Model
{
    public class Star
    {
        public string Id { get; init; } = string.Empty;

        public string StarSystemId { get; init; } = string.Empty;

        public string? OrbitParentId { get; init; } = null;

        public string Name { get; init; } = string.Empty;

        public override string ToString() => $"{{ Name: {Name}; Id: {Id}; StarSystemId: {StarSystemId} }}";
    }
}
