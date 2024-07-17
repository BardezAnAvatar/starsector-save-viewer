using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class p_Reader(ILogger<p_Reader> logger, ICommanderReader commanderReader,
        IConnectedEntityReader connectedEntityReader, IStagesReader stagesReader, Is_Reader sReader)
        : Ip_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var commander = current.Element("commander");
            var connectedEntity = current.Element("connectedEntity");
            var s = current
                .Element("i")
                ?.Element("s");
            var stages = current.Element("stages");

            if (commander is not null)
            {
                commanderReader.Read(commander, data);
            }

            if (connectedEntity is not null)
            {
                connectedEntityReader.Read(connectedEntity, data);
            }

            if (s is not null)
            {
                sReader.Read(s, data);
            }

            if (stages is not null)
            {
                stagesReader.Read(stages, data);
            }
        }
    }
}
