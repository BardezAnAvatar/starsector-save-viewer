using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class GenesisStationIntelReader(ILogger<GenesisStationIntelReader> logger,
        IPrimaryEntityReader primaryEntityReader)
        : IGenesisStationIntelReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var primaryEntity = current
                .Element("event")
                ?.Element("shownAt")
                ?.Element("primaryEntity")
                ;

            if (primaryEntity is not null)
            {
                primaryEntityReader.Read(primaryEntity, data);
            }
        }
    }
}
