﻿using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class PersonReader(ILogger<PersonReader> logger, Lazy<IMarketReader> marketReader) : IPersonReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var market = current.Element("market");

            if (market is not null)
            {
                marketReader.Value.Read(market, data);
            }
        }
    }
}
