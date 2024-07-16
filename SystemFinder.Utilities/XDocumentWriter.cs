using System.Xml.Linq;

namespace SystemFinder.Utilities
{
    internal class XDocumentWriter
    {
        private const string _outPath = @"C:\Code\Starsector\SystemFinder\Data\snippets\";

        internal static void WriteSstm(XDocument document)
        {
            var outFile = "Systems_Sstm.xml";
            var outFilePath = Path.Combine(_outPath, outFile);
            document.Save(outFilePath);
        }

        internal static void WriteNonSstmSystems(XDocument document)
        {
            var outFile = "Systems_NonSstm.xml";
            var outFilePath = Path.Combine(_outPath, outFile);
            document.Save(outFilePath);
        }

        internal static void WriteXPathsForSystems(XDocument document)
        {
            var outFile = "Systems_XPath.xml";
            var outFilePath = Path.Combine(_outPath, outFile);
            document.Save(outFilePath);
        }
    }
}
