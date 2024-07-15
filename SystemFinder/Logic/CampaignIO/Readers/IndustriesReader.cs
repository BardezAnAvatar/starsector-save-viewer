﻿using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class IndustriesReader(FleetReader fleetReader) : IIndustriesReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var fleet = current
                .Element("boggled.campaign.econ.industries.Boggled__Cryosanctum")
                ?.Element("thisIndustry")
                ?.Element("ctx")
                ?.Element("fleet")
                ;

            if (fleet is not null)
            {
                fleetReader.Read(fleet, data);
            }
        }
    }
}
