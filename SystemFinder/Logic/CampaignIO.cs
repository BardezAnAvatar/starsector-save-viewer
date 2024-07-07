using System.Xml;
using System.Xml.Linq;
using SystemFinder.Model;

namespace SystemFinder.Logic
{
    internal class CampaignIO
    {
        public static List<StarSystem> ReadSave(Stream file)
        {
            using XmlReader reader = XmlReader.Create(file);
            XNode root = XDocument.ReadFrom(reader);

            //TODO: Code

            return [];
        }
    }
}
