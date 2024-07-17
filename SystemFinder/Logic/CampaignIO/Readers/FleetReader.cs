﻿using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class FleetReader(ILogger<FleetReader> logger, IcL_Reader clReader, IdL_Reader dlReader,
        IOrbitReader orbitReader, IScriptReader scReader)
        : IFleetReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var cL = current.Element("cL");
            var dL = current.Element("dL");
            var itOrbit = current.Element("iT")?.Element("orbit");
            var sc = current.Element("sc");

            if (cL is not null)
            {
                clReader.Read(cL, data);
            }

            if (dL is not null)
            {
                dlReader.Read(dL, data);
            }

            if (itOrbit is not null)
            {
                orbitReader.Read(itOrbit, data);
            }

            if (sc is not null)
            {
                scReader.Read(sc, data);
            }
        }
    }
}
