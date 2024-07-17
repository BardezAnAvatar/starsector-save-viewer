using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class EntryReader(ILogger<EntryReader> logger, IFleetReader fleetReader, Im_Reader mReader)
        : IEntryReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var fleet =
                current
                .Element("stats")
                ?.Element("fleet")
                ;

            var m =
                current
                .Element("m")
                ;

            if (fleet is not null)
            {
                fleetReader.Read(fleet, data);
            }

            if (m is not null)
            {
                mReader.Read(m, data);
            }
        }
    }
}
