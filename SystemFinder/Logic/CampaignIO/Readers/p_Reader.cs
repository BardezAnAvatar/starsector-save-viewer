using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class p_Reader(ILogger<p_Reader> logger, ICommanderReader commanderReader,
        IConnectedEntityReader connectedEntityReader, Im_Reader mReader, IStagesReader stagesReader)
        : Ip_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var commander = current.Element("commander");
            var connectedEntity = current.Element("connectedEntity");
            var m = current
                .Element("i")
                ?.Element("sm")
                ?.Element("m");
            var stages = current.Element("stages");

            if (commander is not null)
            {
                commanderReader.Read(commander, data);
            }

            if (connectedEntity is not null)
            {
                connectedEntityReader.Read(connectedEntity, data);
            }

            if (m is not null)
            {
                mReader.Read(m, data);
            }

            if (stages is not null)
            {
                stagesReader.Read(stages, data);
            }
        }
    }
}
