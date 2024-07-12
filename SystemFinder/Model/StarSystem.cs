﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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