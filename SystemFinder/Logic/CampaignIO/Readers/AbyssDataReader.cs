using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class AbyssDataReader(ILogger<AbyssDataReader> logger, Ip_Reader pReader) : IAbyssDataReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var p =
                current
                .Element("hyperspaceFracture")
                ?.Element("p")
                ;

            if (p is not null)
            {
                pReader.Read(p, data);
            }
        }
    }
}
