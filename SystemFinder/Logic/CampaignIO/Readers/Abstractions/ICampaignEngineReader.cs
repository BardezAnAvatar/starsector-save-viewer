using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Abstractions
{
    public interface ICampaignEngineReader
    {
        void Read(XDocument root, GalaxyData data);
    }
}