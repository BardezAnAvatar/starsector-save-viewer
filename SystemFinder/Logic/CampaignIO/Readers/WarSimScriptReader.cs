using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class WarSimScriptReader(ILogger<WarSimScriptReader> logger, ISstmReader systemReader)
        : IWarSimScriptReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var sstm = current
                .Element("queue")
                ?.Elements("Sstm")
                ;

            if (sstm is not null && sstm.Any())
            {
                foreach (var element in sstm)
                {
                    systemReader.Read(element, data);
                }
            }
        }
    }
}
