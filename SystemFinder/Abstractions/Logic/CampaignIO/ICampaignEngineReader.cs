using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Abstractions.Logic.CampaignIO
{
    public interface ICampaignEngineReader
    {
        void Read(XDocument root, GalaxyData data);
    }
}