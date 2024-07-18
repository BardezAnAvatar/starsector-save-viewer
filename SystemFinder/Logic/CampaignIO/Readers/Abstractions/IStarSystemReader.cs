using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Abstractions.Model
{
    public interface IStarSystemReader
    {
        void Read(XElement current, XAttribute uid, GalaxyData data);
    }
}