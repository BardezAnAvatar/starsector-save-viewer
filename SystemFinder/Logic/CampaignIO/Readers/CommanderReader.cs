﻿using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CommanderReader(IStatsReader statsReader) : ICommanderReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            var stats = current.Element("stats");

            if (stats is not null)
            {
                statsReader.Read(stats, data);
            }
        }
    }
}
