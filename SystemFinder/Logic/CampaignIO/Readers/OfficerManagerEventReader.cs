using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OfficerManagerEventReader(ILogger<OfficerManagerEventReader> logger, IPersonReader personReader)
        : IOfficerManagerEventReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var available =
                current
                .Element("available")
                ;

            if (available is not null)
            {
                var officers = available.Elements("AvailableOfficer");

                if (officers.Any())
                {
                    foreach (var element in officers)
                    {
                        personReader.Read(element, data);
                    }
                }
            }
        }
    }
}
