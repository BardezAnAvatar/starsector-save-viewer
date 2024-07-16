using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Abstractions
{
    public interface IOrbitalStationReader
    {
        void Read(XElement current, GalaxyData data);
    }
}