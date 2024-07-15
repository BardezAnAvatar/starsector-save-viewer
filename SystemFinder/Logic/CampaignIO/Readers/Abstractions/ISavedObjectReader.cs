using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Abstractions
{
    public interface ISavedObjectReader
    {
        void Read(XElement current, GalaxyData data);
    }
}