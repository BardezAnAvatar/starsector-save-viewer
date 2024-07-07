using System.Xml;
using System.Xml.Linq;
using SystemFinder.Model;

namespace SystemFinder.Logic
{
    internal class CampaignIO
    {
        public static List<StarSystem> ReadSave(Stream file)
        {
            XNode root = XDocument.Load(file);

            //TODO: Code

            return [];
        }
    }
}
