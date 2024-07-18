using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class SurveyPlanetMissionIntelReader(ILogger<SurveyPlanetMissionIntelReader> logger,
        IPlanetReader planetReader) : ISurveyPlanetMissionIntelReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var planet = current.Element("planet");

            if (planet is not null)
            {
                planetReader.Read(planet, data);
            }
        }
    }
}
