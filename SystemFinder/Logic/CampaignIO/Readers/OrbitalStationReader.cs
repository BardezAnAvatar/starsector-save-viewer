using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OrbitalStationReader(ILogger<OrbitalStationReader> logger, IdL_Reader dlReader)
        : IOrbitalStationReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var dl = current
                .Element("sf")
                ?.Element("dL")
                ;

            if (dl is not null)
            {
                dlReader.Read(dl, data);
            }
        }
    }
}
