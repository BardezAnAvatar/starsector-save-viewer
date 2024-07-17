using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Abstractions
{
    public interface ICampaignEngineReader
    {
        void Read(XDocument root, GalaxyData data);
    }
}