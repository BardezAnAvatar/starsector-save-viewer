﻿using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class CentReader(ILogger<CentReader> logger, Lazy<IMarketReader> marketReader, IMetadataReader meReader)
        : ICentReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var market = current.Element("market");
            var me = current.Element("me");

            if (market is not null)
            {
                marketReader.Value.Read(market, data);
            }

            if (me is not null)
            {
                meReader.Read(me, data);
            }
        }
    }
}
