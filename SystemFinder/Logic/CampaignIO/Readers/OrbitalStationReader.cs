﻿using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class OrbitalStationReader(dL_Reader dlReader) : IOrbitalStationReader
    {
        public void Read(XElement current, GalaxyData data)
        {
        }
    }
}
