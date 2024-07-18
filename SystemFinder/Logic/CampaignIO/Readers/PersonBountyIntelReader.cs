using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PersonBountyIntelReader(ILogger<PersonBountyIntelReader> logger, IPersonReader personReader)
        : IPersonBountyIntelReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var person = current.Element("person");

            if (person is not null)
            {
                personReader.Read(person, data);
            }
        }
    }
}
