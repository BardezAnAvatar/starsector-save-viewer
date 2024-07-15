using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OfficerManagerEventReader(PersonReader personReader) : IOfficerManagerEventReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var available =
                current
                .Element("available")
                ;

            if (available is not null)
            {
                var officers = available.Elements("AvailableOfficer");

                if (officers.Any())
                {
                    foreach (var element in officers)
                    {
                        personReader.Read(element, data);
                    }
                }
            }
        }
    }
}
