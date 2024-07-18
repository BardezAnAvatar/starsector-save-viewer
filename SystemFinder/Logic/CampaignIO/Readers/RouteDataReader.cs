using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class RouteDataReader(ILogger<RouteDataReader> logger, Lazy<Ie_Reader> eReader, Im_Reader mReader,
        Ip_Reader pReader) : IRouteDataReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var e = current.Element("e");
            var m = current.Element("m");
            var p = current.Element("p");

            if (e is not null)
            {
                eReader.Value.Read(e, data);
            }

            if (m is not null)
            {
                mReader.Read(m, data);
            }

            if (p is not null)
            {
                pReader.Read(p, data);
            }
        }
    }
}
