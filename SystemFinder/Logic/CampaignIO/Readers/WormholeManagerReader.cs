using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class WormholeManagerReader(ILogger<EventReader> logger, IOrbitReader orbitReader)
        : IWormholeManagerReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var orbit = current
                .Element("deployed")
                ?.Element("com.fs.starfarer.api.impl.campaign.shared.WormholeManager_-WormholeData")
                ?.Element("jumpPoint")
                ?.Element("orbit");

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }
        }
    }
}
