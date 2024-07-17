using System.Xml.Linq;
using SystemFinder.Logic.Abstractions;
using SystemFinder.Logic.CampaignIO.Abstractions;
using SystemFinder.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic
{
    public class CampaignIoLogic(ICampaignEngineReader reader) : ICampaignIoLogic
    {
        public GalaxyData ReadSave(Stream file)
        {
            XDocument root = XDocument.Load(file);
            var data = TraverseSave(root);
            return data;
        }

        private GalaxyData TraverseSave(XDocument root)
        {
            var data = new GalaxyData();

            reader.Read(root, data);

            return data;
        }
    }
}
