﻿using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class dL_Reader(IRouteDataReader routeDataReader) : IdL_Reader
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
