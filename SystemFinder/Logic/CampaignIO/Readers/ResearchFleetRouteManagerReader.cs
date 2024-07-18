using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ResearchFleetRouteManagerReader(ILogger<ResearchFleetRouteManagerReader> logger,
        ITargetReader targetReader) : IResearchFleetRouteManagerReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var target = current.Element("target");

            if (target is not null)
            {
                targetReader.Read(target, data);
            }
        }
    }
}
