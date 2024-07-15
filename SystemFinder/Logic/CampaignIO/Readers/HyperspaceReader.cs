using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class HyperspaceReader(ISavedObjectReader osavedReader) : IHyperspaceReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var o = current.Element("o");

            if (o is not null)
            {
                osavedReader.Read(o, data);
            }
        }
    }
}
