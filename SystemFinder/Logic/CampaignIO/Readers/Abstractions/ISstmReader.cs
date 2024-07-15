using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Abstractions
{
    public interface ISstmReader
    {
        void Read(XElement current, GalaxyData data);
    }
}