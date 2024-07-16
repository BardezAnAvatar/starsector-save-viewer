using System.Xml.Linq;

namespace SystemFinder.Utilities
{
    internal static class XDocumentCreator
    {
        internal static XDocument IsolateSstm(XDocument root)
        {
            var sstm = root.Descendants("Sstm");

            var actual = sstm.Where(e => e.Attribute("z") is not null);
            var reference = sstm.Where(e => e.Attribute("ref") is not null);

            var container = new XElement("Systems");
            foreach (var element in actual)
            {
                container.Add(element);
            }
            foreach (var element in reference)
            {
                container.Add(element);
            }

            var container2 = new XElement("SystemsButNotExactly");

            var filter = root
                .Descendants()
                .Where(d => d.Attribute("z") is not null && d.Attribute("cl")?.Value == "Sstm")
                ;

            var count = filter.Count();
            foreach (var element in filter)
            {
                container2.Add(element);
            }

            var newDoc = new XDocument();

            var containerMain = new XElement("Snippets");
            containerMain.Add(container);
            containerMain.Add(container2);
            newDoc.Add(containerMain);

            return newDoc;
        }
    }
}
