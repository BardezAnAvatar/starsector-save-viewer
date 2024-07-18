using System;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ActiveReader(ILogger<ActiveReader> logger, IPersonBountyIntelReader personBountyIntelReader)
        : IActiveReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var personBountyIntel = current.Elements("PersonBountyIntel");

            if (personBountyIntel is not null && personBountyIntel.Any())
            {
                foreach (var element in personBountyIntel)
                {
                    personBountyIntelReader.Read(element, data);
                }
            }
        }
    }
}
