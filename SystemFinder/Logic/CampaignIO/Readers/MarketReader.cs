using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class MarketReader(ICommDirectoryReader commReader, IConditionsReader conditionsReader,
        IEconomyReader economyReader, IImmigrationModifiersReader immigrationModifiersReader,
        IIndustriesReader industriesReader, IPrimaryEntityReader primaryEntityReader) : IMarketReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var commDirectory = current.Element("commDirectory");
            var economy = current.Element("economy");
            var immigrationModifiers = current.Element("immigrationModifiers");
            var industries = current.Element("industries");
            var primaryEntity = current.Element("primaryEntity");
            var conditions = current.Element("conditions");

            if (commDirectory is not null)
            {
                commReader.Read(commDirectory, data);
            }

            if (economy is not null)
            {
                economyReader.Read(economy, data);
            }

            if (immigrationModifiers is not null)
            {
                immigrationModifiersReader.Read(immigrationModifiers, data);
            }

            if (industries is not null)
            {
                industriesReader.Read(industries, data);
            }

            if (primaryEntity is not null)
            {
                primaryEntityReader.Read(primaryEntity, data);
            }

            if (conditions is not null)
            {
                conditionsReader.Read(conditions, data);
            }
        }
    }
}
