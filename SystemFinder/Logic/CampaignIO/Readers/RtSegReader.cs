using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class RtSegReader(t_Reader tReader) : IRtSegReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var t = current.Element("t");

            if (t is not null)
            {
                tReader.Read(t, data);
            }
        }
    }
}
