using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class cL_Reader(ConReader conReader, SavedObjectReader osavedReader, StarSystemReader sstmReader) : IcL_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var uid = current.Attribute("z");
            var cl = current.Attribute("cl");

            //if `z` is present, it is an entity definition; `ref` is just a reference instead.
            if (uid is not null && cl is not null && cl.Value == "Sstm")
            {
                sstmReader.Read(current, uid, data);
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
