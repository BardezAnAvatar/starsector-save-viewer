using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class ConditionsReader(ILogger<ConditionsReader> logger, Ip_Reader pReader) : IConditionsReader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var mcon = current
                .Elements("MCon")
                ;

            if (mcon is not null && mcon.Any())
            {
                foreach (var element in mcon)
                {
                    var p = element.Element("p");
                    if (p is not null)
                    {
                        pReader.Read(element, data);
                    }
                }
            }
        }
    }
}
