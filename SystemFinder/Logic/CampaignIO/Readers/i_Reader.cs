using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class i_Reader(ILogger<i_Reader> logger, Im_Reader mReader, Is_Reader sReader) : Ii_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());
            var s = current.Element("s");
            var m = current.Element("sm")?.Element("m");

            if (s is not null)
            {
                sReader.Read(s, data);
            }

            if (m is not null)
            {
                mReader.Read(m, data);
            }
        }
    }
}
