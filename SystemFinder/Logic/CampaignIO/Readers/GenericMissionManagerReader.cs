using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class GenericMissionManagerReader(ILogger<GenericMissionManagerReader> logger,
        IActiveReader activeReader) : IGenericMissionManagerReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var active = current.Element("active");

            if (active is not null)
            {
                activeReader.Read(active, data);
            }
        }
    }
}
