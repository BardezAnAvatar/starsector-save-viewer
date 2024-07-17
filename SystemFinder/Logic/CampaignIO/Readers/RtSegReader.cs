using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class RtSegReader(ILogger<RtSegReader> logger, If_Reader fReader, It_Reader tReader) : IRtSegReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var t = current.Element("t");
            var f = current.Element("f");

            if (t is not null)
            {
                tReader.Read(t, data);
            }

            if (f is not null)
            {
                fReader.Read(f, data);
            }
        }
    }
}
