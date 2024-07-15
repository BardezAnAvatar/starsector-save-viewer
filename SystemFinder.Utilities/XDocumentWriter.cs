using System.Xml.Linq;

namespace SystemFinder.Utilities
{
    internal class XDocumentWriter
    {
        private const string _outPath = @"C:\Code\Starsector\SystemFinder\Data\snippets\";

        internal static void WriteSstm(XDocument document)
        {
            var outFile = "Sstm.xml";
            var outFilePath = Path.Combine(_outPath, outFile);
            document.Save(outFilePath);
        }
    }
}
