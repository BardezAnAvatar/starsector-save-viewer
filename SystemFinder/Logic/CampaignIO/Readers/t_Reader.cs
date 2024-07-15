using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class t_Reader(cL_Reader clReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var cL = current.Element("cL");

            if (cL is not null)
            {
                clReader.Read(cL, data);
            }
        }
    }
}
