using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class dL_Reader(ILogger<dL_Reader> logger, IRouteDataReader routeDataReader, ITargetReader targetReader)
        : IdL_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var routeManager = current.Element("RouteManager");
            var target = current
                .Element("exerelin.campaign.intel.bases.NexPirateBaseIntel")
                ?.Element("target");

            if (target is not null)
            {
                targetReader.Read(target, data);
            }

            if (routeManager is not null)
            {
                var routeData = routeManager.Element("r")?.Elements("RouteData");

                if (routeData is not null && routeData.Any())
                {
                    foreach (var element in routeData)
                    {
                        routeDataReader.Read(element, data);
                    }
                }
            }
        }
    }
}
