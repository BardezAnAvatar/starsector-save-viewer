using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ImmigrationModifiersReader(ILogger<ImmigrationModifiersReader> logger, Ie_Reader eReader)
        : IImmigrationModifiersReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var e = current
                .Element("ColonyMngr")
                ?.Element("npcConstructionQueues")
                ?.Elements("e")
                ;

            if (e is not null && e.Any())
            {
                foreach (var element in e)
                {
                    eReader.Read(element, data);
                }
            }
        }
    }
}
