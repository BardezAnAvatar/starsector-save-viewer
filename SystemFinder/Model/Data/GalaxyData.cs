using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFinder.Model.Data
{
    public class GalaxyData
    {
        public Dictionary<string, Planet> Planets = new();
        public Dictionary<string, StarSystem> StarSystems = new();
        public Dictionary<string, Fleet> Fleets = new();
        public Dictionary<string, Station> Stations = new();
    }
}
