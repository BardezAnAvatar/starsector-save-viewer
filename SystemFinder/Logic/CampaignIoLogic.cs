using System.Xml.Linq;
using SystemFinder.Abstractions.Logic;
using SystemFinder.Abstractions.Logic.CampaignIO;
using SystemFinder.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic
{
    public class CampaignIoLogic(ICampaignEngineReader reader) : ICampaignIoLogic
    {
        public async Task<GalaxyData> ReadSave(Stream file, CancellationToken cancellation)
        {
            XDocument root = await XDocument.LoadAsync(file, LoadOptions.None, cancellation);
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
