using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class StarSystemsReader(ILogger<StarSystemsReader> logger, ISstmReader sstmReader) : IStarSystemsReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var sstm = current.Elements("Sstm");

            if (sstm != null && sstm.Any())
            {
                foreach (var element in sstm)
                {
                    sstmReader.Read(element, data);
                }
            }
        }
    }
}
