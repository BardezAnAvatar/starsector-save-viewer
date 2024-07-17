﻿using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions.Model;
using SystemFinder.Model.Data;
using SystemFinder.Shared;

namespace SystemFinder.Logic.CampaignIO.Readers
{
    public class s_Reader(ILogger<s_Reader> logger, IConReader conReader, Lazy<ISavedObjectReader> osavedReader,
        IStarSystemReader sstmReader)
        : Is_Reader
    {
        public void Read(XElement current, GalaxyData data)
        {
            logger.Log(LogLevel.Debug, current.GetAbsoluteXPath());

            var uid = current.Attribute("z");
            var cl = current.Attribute("cl");

            //if `z` is present, it is an entity definition; `ref` is just a reference instead.
            if (uid is not null && cl is not null && cl.Value == "Sstm")
            {
                sstmReader.Read(current, uid, data);
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
