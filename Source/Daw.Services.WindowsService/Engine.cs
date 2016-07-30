using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Daw.Client.WebServices.Clients;
using Daw.Client.WebServices.Interfaces;
using Daw.Common.Configuration;
using Daw.Common.CoreData;
using IncomingFeedQueue;
using log4net;
using XsltTransformer;

namespace Daw.Services.WindowsService
{

    public class EventPacket
    {
        public ScheduleConfigItem ConfigItem { get; set; }
        public DateTime NextRun { get; set; }
        public Task<XmlDocument> Return { get; set; }
    }

    public static class Engine
    {
        public static LatestDataQueue<XmlPacket> IncomingQueue = new LatestDataQueue<XmlPacket>("FeedQueue");
        public static LatestDataQueue<ProcessedDataPacket> OutgoingQueue = new LatestDataQueue<ProcessedDataPacket>("TransformedQueue");
        public static Dictionary<int, EventPacket> Events = new Dictionary<int, EventPacket>();


        public static void ScheduleTransforms()
        {
            while (1 == 1)
            {
                var item = IncomingQueue.GetMostRecentData();
                if (item != null)
                {
                    var packet = new ProcessedDataPacket
                    {
                        ConfigItem = item.Data.ConfigItem
                    };

                    var qi = new QueueItem<ProcessedDataPacket>(item.Source, DateTime.Now, packet);
                    
                    var doc = TransformXml.XsltTransform(item, OddFeedService.Logger);
                    var obj = DeserializeXml.Deserialize(doc, OddFeedService.Logger);
                    if (obj != null)
                    {
                        packet.ProcessedObject = obj;
                        OutgoingQueue.AddData(qi);
                    }
                }
                else
                {
                    Thread.Sleep(5000);
                }
            }
        }

        public static void ScheduleEvents(ILog logger)
        {
            var sc = new SecretClient();
            var client = sc.Open();
            var scConfig = SchedulerConfigSection.Instance.Schedules;
            // Load up the tasks
            for (int i = 0; i < scConfig.Count; i++)
            {
                ScheduleConfigItem it = scConfig.GetItemAt(i);
                if (it.type == "xml" && it.enabled)
                {
                    var task = Task<XmlDocument>.Run(() => LoadXmlFromUrl(client, it));
                    logger.Debug(string.Format("Just run load {0}", it.url));
                    Events.Add(i, new EventPacket() { ConfigItem = it, Return = task, NextRun = DateTime.Now.AddSeconds(it.intervalsecs) });
                }
            }
            while (1 == 1)
            {
                // Run them for a bit
                for (int i = 0; i < scConfig.Count; i++)
                {
                    ScheduleConfigItem it = scConfig.GetItemAt(i);
                    if (it.type == "xml" && it.enabled)
                    {
                        var runningEvent = Events[i];
                        if (runningEvent.Return != null && runningEvent.Return.IsCompleted)
                        {
                            XmlDocument x = runningEvent.Return.Result;
                            if (x != null)
                            {
                                var item = new QueueItem<XmlPacket>(it.bookie, DateTime.Now, new XmlPacket() { ConfigItem = it, Xml = x });
                                logger.Debug(string.Format("Adding feed data to the queue {0}", item.Source));
                                IncomingQueue.AddData(item);
                                runningEvent.Return = null;
                            }

                        }
                        if (runningEvent.Return == null &&  DateTime.Now > runningEvent.NextRun)
                        {
                            logger.Debug(string.Format("Next run of {0}", runningEvent.ConfigItem.bookie));
                            runningEvent.Return = Task<XmlDocument>.Run(() =>
                            {
                                return LoadXmlFromUrl(client, it);

                            });
                            runningEvent.NextRun = DateTime.Now.AddSeconds(it.intervalsecs);
                        }
                    }
                }
            }
            sc.Close(client);
        }

        private static XmlDocument LoadXmlFromUrl(IWhiteListedUrlService client, ScheduleConfigItem it)
        {
            try
            {
                return client.LoadXmlFromUrl(it.url);
            }
            catch (Exception ex)
            {
                OddFeedService.Logger.Fatal(string.Format("LoadXmlFromUrl {0} failed for {1}", it.url, ex.Message));
                return null;
            }
        }
    }
}
