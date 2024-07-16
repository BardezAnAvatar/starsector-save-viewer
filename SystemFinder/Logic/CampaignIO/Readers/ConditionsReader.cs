using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ConditionsReader(Ip_Reader pReader) : IConditionsReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var mcon = current
                .Elements("MCon")
                ;

            if (mcon is not null && mcon.Any())
            {
                foreach (var element in mcon)
                {
                    var p = element.Element("p");
                    if (p is not null)
                    {
                        pReader.Read(element, data);
                    }
                }
            }
        }
    }
}
