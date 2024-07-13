using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class dL_Reader(RouteDataReader routeDataReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var routeManager = current.Element("RouteManager");

            if (routeManager is not null)
            {
                var r = routeManager.Element("r")!;
                var routeData = r.Elements("RouteData");

                if (routeData.Any())
                {
                    foreach (var element in routeData)
                    {
                        routeDataReader.Read(element, data);
                    }
                }
            }
        }
    }
}
