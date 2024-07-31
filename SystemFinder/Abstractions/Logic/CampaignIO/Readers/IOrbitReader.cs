using System.Xml.Linq;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public interface IOrbitReader
    {
        string? ExtractOrbitReference(XElement current, string xPath);
    }
}