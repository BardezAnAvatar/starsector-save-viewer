using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers;
using SystemFinder.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic
{
    public class CampaignIoLogic(CampaignEngineReader reader)
    {
        public List<StarSystem> ReadSave(Stream file)
        {
            XDocument root = XDocument.Load(file);

            //TODO: Code
            var systems = TraverseSave(root);

            return [];
        }

        private GalaxyData TraverseSave(XDocument root)
        {
            var data = new GalaxyData();

            reader.Read(root, data);

            return data;
        }
    }
}
