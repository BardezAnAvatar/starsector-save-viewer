using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CryosanctumReader(ILogger<CryosanctumReader> logger, IFleetReader fleetReader) : ICryosanctumReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var fleet = current
                .Element("thisIndustry")
                ?.Element("ctx")
                ?.Element("fleet")
                ;

            if (fleet is not null)
            {
                fleetReader.Read(fleet, data);
            }
        }
    }
}
