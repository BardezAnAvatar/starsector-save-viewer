﻿using System.Xml.Linq;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO
{
    public class FleetReader(dL_Reader dlReader, ScriptReader scReader)
    {
        public void Read(XElement current, GalaxyData data)
        {
            var dL = current.Element("dL");
            var sc = current.Element("sc");

            if (dL is not null)
            {
                dlReader.Read(dL, data);
            }

            if (sc is not null)
            {
                scReader.Read(sc, data);
            }
        }
    }
}
