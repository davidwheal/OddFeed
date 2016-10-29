using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Daw.Common.CoreData;
using Daw.Common.CoreData.IncomingData;
using Daw.Common.CoreData.IntermediateData;
using Daw.Common.CoreData.ProcessorData;
using IncomingFeedQueue;
using log4net;
using Daw.Common.Interfaces;

namespace Daw.Services.WindowsService.WebService
{
    public class EngineWebService : IEngineWebService
    {
        //private ILog _logger = null;
        //public EngineWebService(ILog logger)
        //{
        //    _logger = logger;
        //}
        public MostRecentDataQueue<XmlPacket>.StatisticsPacket GetIncomingFeedStatistics()
        {
            return Engine.IncomingQueue.Stats;
        }

        public MostRecentDataQueue<ProcessedDataPacket>.StatisticsPacket GetProcessingFeedStatistics()
        {
            return Engine.OutgoingQueue.Stats;
        }

        public Dictionary<string, BaseFeedDto> GetFeeds()
        {
            var result = new Dictionary<string, BaseFeedDto>();
            foreach (var kvp in Engine.DataRoot)
            {
                result.Add(kvp.Key, new BaseFeedDto()
                {
                    Sport = kvp.Value.TheSport.Name,
                    FeedName = kvp.Value.TheFeedDefinition.name,
                    FixturesOnly = kvp.Value.TheFeedDefinition.fixturesonly
                });
            }
            return result;
        }

        public Dictionary<string, EventDto> GetEvents(string feedKey)
        {
            BaseFeed it;
            if (Engine.DataRoot.TryGetValue(feedKey, out it))
            {
                var result = new Dictionary<string, EventDto>();
                try
                {
                    var evList = it.TheSport.TheEvents;
                    foreach (var ev in evList)
                    {
                        result.Add(ev.Key, new EventDto(ev.Value));
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    Engine.Logger.Fatal(string.Format("GetEvents Exception {0}", ex.Message));
                    return null;
                }

            }
            else
            {
                return null;
            }
        }


        public Dictionary<string, MarketDto> GetMarkets(string feedKey, string eventKey)
        {
            BaseFeed it;
            if (Engine.DataRoot.TryGetValue(feedKey, out it))
            {
                if (it.TheSport.TheEvents.ContainsKey(eventKey))
                {
                    var theEvent = it.TheSport.TheEvents[eventKey];
                    var result = new Dictionary<string, MarketDto>();
                    try
                    {
                        foreach (var mk in theEvent.TheMarkets)
                        {
                            result.Add(mk.Key, new MarketDto(mk.Value));
                        }
                        return result;
                    }
                    catch (Exception ex)
                    {
                        Engine.Logger.Fatal(string.Format("GetMarkets Exception {0}", ex.Message));
                        return null;
                    }
                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }
        }
    }

}