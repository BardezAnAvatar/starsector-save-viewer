using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class MetadataReader(ILogger<MetadataReader> logger, Ie_Reader eReader) : IMetadataReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var e = current
                .Element("d")
                ?.Elements("e");

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
