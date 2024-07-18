using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class FleetReader(ILogger<FleetReader> logger, IcL_Reader clReader, IdL_Reader dlReader,
        IOrbitReader orbitReader, IiT_Reader itReader, IScriptReader scReader)
        : IFleetReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var cL = current.Element("cL");
            var dL = current.Element("dL");
            var iT = current.Element("iT");
            var orbit = current.Element("orbit");
            var sc = current.Element("sc");

            if (cL is not null)
            {
                clReader.Read(cL, data);
            }

            if (dL is not null)
            {
                dlReader.Read(dL, data);
            }

            if (iT is not null)
            {
                itReader.Read(iT, data);
            }

            if (orbit is not null)
            {
                orbitReader.Read(orbit, data);
            }

            if (sc is not null)
            {
                scReader.Read(sc, data);
            }
        }
    }
}
