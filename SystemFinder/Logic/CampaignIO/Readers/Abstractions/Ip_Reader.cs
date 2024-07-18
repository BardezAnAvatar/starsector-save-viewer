using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Abstractions
{
    public interface Ip_Reader
    {
        void Read(XElement current, GalaxyData data);
    }
}