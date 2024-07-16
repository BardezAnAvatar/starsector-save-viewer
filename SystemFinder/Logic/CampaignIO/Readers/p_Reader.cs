using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class p_Reader(ICommanderReader commanderReader, IStagesReader stagesReader, Is_Reader sReader) : Ip_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var s = current
                .Element("i")
                ?.Element("s");
            var commander = current.Element("commander");
            var stages = current.Element("stages");

            if (s is not null)
            {
                sReader.Read(s, data);
            }

            if (commander is not null)
            {
                commanderReader.Read(commander, data);
            }

            if (stages is not null)
            {
                stagesReader.Read(stages, data);
            }
        }
    }
}
