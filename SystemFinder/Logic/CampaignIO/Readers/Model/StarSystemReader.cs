using System.Xml.Linq;
using SystemFinder.Model;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers.Model
{
    public class StarSystemReader
    {
        public void Read(XElement current, XAttribute uid, GalaxyData data)
        {
            var descriptiveName = current.Attribute("dN");
            var shortName = current.Attribute("bN");
            var systemType = current.Attribute("ty");

            var system = new StarSystem
            {
                Ref = uid.Value,
                Name = shortName!.Value,
            };

            data.StarSystems.Add(uid.Value, system);
        }
    }
}
