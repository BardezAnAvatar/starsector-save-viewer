using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Abstractions.Logic.CampaignIO.Readers;
using SystemFinder.Model;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers.Model
{
    public class StarSystemReader(ILogger<StarSystemReader> logger) : IStarSystemReader
    {
        public void Read(XElement current, XAttribute uid, GalaxyData data)
        {
            logger.Log(LogLevel.Information, $"Reading System: {current.GetAbsoluteXPath()}");

            //NOTE: there appears to be some duplicate serialization for `cL` and maybe `s`, so check first
            if (!data.StarSystems.ContainsKey(uid.Value))
            {
                var descriptiveName = current.Attribute("dN");
                var shortName = current.Attribute("bN");
                var systemType = current.Attribute("ty");

                var system = new StarSystem
                {
                    Ref = uid.Value,
                    Name = shortName!.Value,
                };

                data.StarSystems.Add(uid.Value, system);
            }
        }
    }
}
