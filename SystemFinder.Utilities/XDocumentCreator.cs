using System.Xml.Linq;
using SystemFinder.Shared;

namespace SystemFinder.Utilities
{
    internal static class XDocumentCreator
    {
        internal static int CountUniqueElements(XDocument root)
        {
            var distinct = root.Descendants().Select(e => e.Name).Distinct();

            return distinct.Count();
        }


        internal static XDocument IsolateSstm(XDocument root)
        {
            var sstm = root.Descendants("Sstm");

            var actual = sstm.Where(e => e.Attribute("z") is not null);
            var reference = sstm.Where(e => e.Attribute("ref") is not null);

            var container = new XElement("Systems");
            foreach (var element in actual)
            {
                container.Add(element);
                XPaths.Paths.Add(element.GetAbsoluteXPath());
            }
            foreach (var element in reference)
            {
                container.Add(element);
            }

            var newDoc = new XDocument();

            var containerMain = new XElement("Snippets");
            containerMain.Add(container);
            newDoc.Add(containerMain);

            return newDoc;
        }
        
        internal static XDocument IsolateNonSstmSystems(XDocument root)
        {
            var container = new XElement("SystemsButNotExactly");

            var filter = root
                .Descendants()
                .Where(d => d.Attribute("z") is not null && d.Attribute("cl")?.Value == "Sstm")
                ;

            var count = filter.Count();
            foreach (var element in filter)
            {
                container.Add(element);
                XPaths.Paths.Add(element.GetAbsoluteXPath());
            }

            var newDoc = new XDocument();

            var containerMain = new XElement("Snippets");
            containerMain.Add(container);
            newDoc.Add(containerMain);

            return newDoc;
        }

        internal static XDocument IsolateXPaths()
        {
            var container = new XElement("XPaths");

            var count = XPaths.Paths.Count;
            foreach (var xpath in XPaths.Paths)
            {
                var node = new XElement("system", xpath);
                container.Add(node);
            }

            var newDoc = new XDocument();

            var containerMain = new XElement("Snippets");
            containerMain.Add(container);
            newDoc.Add(containerMain);

            return newDoc;
        }
    }
}
