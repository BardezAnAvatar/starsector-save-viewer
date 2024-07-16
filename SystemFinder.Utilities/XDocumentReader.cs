using System.Xml.Linq;

namespace SystemFinder.Utilities
{
    internal static class XDocumentReader
    {
        internal static XDocument OpenDocument()
        {
            var path = @"C:\Code\Starsector\SystemFinder\Data\saves\03-Barielle-AdjustedSector\save_Barielle_4212787207928179895\";
            var file = "campaign.xml";
            var filePath = Path.Combine(path, file);
            XDocument root = XDocument.Load(filePath);

            return root;
        }
    }
}
