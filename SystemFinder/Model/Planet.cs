﻿namespace SystemFinder.Model
{
    public class Planet
    {
        public string Id { get; init; } = string.Empty;

        public string StarSystemId { get; init; } = string.Empty;

        public string Name { get; init; } = string.Empty;

        public bool Colonized { get; init; } = false;

        public bool Surveyed { get; init; } = false;

        public int Size { get; init; } = 0;

        public List<string> Conditions { get; init; } = [];

        public override string ToString() => $"{{ Name: {Name}; Id: {Id}; StarSystemId: {StarSystemId}; Colonized: {Colonized} }}";
    }
}
