using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ConnectedEntityReader(ILogger<ConnectedEntityReader> logger, IcL_Reader clReader)
        : IConnectedEntityReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var cL = current.Element("cL");

            if (cL is not null)
            {
                clReader.Read(cL, data);
            }
        }
    }
}
