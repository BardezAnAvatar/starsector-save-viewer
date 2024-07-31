using System.Xml.Linq;
using SystemFinder.Model;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public interface IOrbitReader
    {
        Orbit? Read(XElement current, string xPath);
    }
}