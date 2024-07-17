using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class HyperspaceReader(ILogger<HyperspaceReader> logger, Lazy<ISavedObjectReader> osavedReader)
        : IHyperspaceReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var o = current.Element("o");

            if (o is not null)
            {
                osavedReader.Value.Read(o, data);
            }
        }
    }
}
