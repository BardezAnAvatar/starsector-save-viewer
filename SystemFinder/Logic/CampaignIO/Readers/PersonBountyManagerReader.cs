using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PersonBountyManagerReader(ILogger<PersonBountyManagerReader> logger, IActiveReader activeReader)
        : IPersonBountyManagerReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var active = current.Element("active");

            if (active is not null)
            {
                activeReader.Read(active, data);
            }
        }
    }
}
