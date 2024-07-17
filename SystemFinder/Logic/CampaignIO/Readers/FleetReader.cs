﻿using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class FleetReader(ILogger<FleetReader> logger, IcL_Reader clReader, IdL_Reader dlReader,
        IScriptReader scReader)
        : IFleetReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var dL = current.Element("dL");
            var sc = current.Element("sc");
            var cL = current.Element("cL");

            if (dL is not null)
            {
                dlReader.Read(dL, data);
            }

            if (sc is not null)
            {
                scReader.Read(sc, data);
            }

            if (cL is not null)
            {
                clReader.Read(cL, data);
            }
        }
    }
}
