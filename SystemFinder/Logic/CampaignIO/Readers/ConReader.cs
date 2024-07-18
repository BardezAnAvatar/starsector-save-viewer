using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ConReader(ILogger<ConReader> logger, Lazy<ISstmReader> sstmReader) : IConReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var sstm = current
                .Element("systems")
                ?.Elements("Sstm");

            if (sstm != null && sstm.Any())
            {
                foreach (var element in sstm)
                {
                    sstmReader.Value.Read(element, data);
                }
            }
        }
    }
}
