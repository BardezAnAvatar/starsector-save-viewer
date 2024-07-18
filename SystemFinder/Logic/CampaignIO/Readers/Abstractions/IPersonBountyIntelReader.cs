using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Abstractions
{
    public interface IPersonBountyIntelReader
    {
        void Read(XElement current, GalaxyData data);
    }
}