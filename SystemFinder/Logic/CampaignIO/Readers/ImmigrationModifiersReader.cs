using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ImmigrationModifiersReader(e_Reader eReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var e = current
                .Element("ColonyMngr")
                ?.Element("npcConstructionQueues")
                ?.Elements("e")
                ;

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
