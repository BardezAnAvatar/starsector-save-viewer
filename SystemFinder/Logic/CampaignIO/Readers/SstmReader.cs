using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Model;
using SystemFinder.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class SstmReader(ConReader conReader, SavedObjectReader osavedReader, StarSystemReader modelReader) : ISstmReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var uid = current.Attribute("z");

            //if `z` is present, it is an entity definition; `ref` is just a reference instead.
            if (uid is not null)
            {
                modelReader.Read(current, uid, data);
            }

            //now go through children
            var con = current.Element("con");
            var o = current.Element("o");

            if (con is not null)
            {
                conReader.Read(con, data);
            }

            if (o is not null)
            {
                osavedReader.Read(o, data);
            }
        }
    }
}
