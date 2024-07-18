using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions.Model;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class SstmReader(ILogger<SstmReader> logger, IConReader conReader, Lazy<ISavedObjectReader> osavedReader,
        IStarSystemReader modelReader)
        : ISstmReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var uid = current.Attribute("z");

            //if `z` is present, it is an entity definition; `ref` is just a reference instead.
            if (uid is not null)
            {
                modelReader.Read(current, uid, data);
            }

            //now go through children
            var con = current.Element("con");
            var o = current.Element("o");

            if (con is not null)
            {
                conReader.Read(con, data);
            }

            if (o is not null)
            {
                osavedReader.Value.Read(o, data);
            }
        }
    }
}
