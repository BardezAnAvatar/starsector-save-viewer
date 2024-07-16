using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class t_Reader(IcL_Reader clReader) : It_Reader
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
