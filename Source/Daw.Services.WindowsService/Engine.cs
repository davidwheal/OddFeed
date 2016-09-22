using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Daw.Client.WebServices.Clients;
using Daw.Common.Interfaces;
using Daw.Common.Configuration;
using Daw.Common.CoreData;
using Daw.Common.CoreData.IncomingData;
using Daw.Common.CoreData.IntermediateData;
using Daw.Common.CoreData.ProcessorData;
using Daw.Services.WindowsService.Exports;
using IncomingFeedQueue;
using log4net;
using XsltTransformer;

namespace Daw.Services.WindowsService
{



    public static class Engine
    {
        public class EventPacket
        {
            public ScheduleConfigItem ConfigItem { get; set; }
            public DateTime NextRun { get; set; }
            public Task<XmlDocument> Return { get; set; }
        }

        public static MostRecentDataQueue<XmlPacket> IncomingQueue = new MostRecentDataQueue<XmlPacket>("FeedQueue");
        public static MostRecentDataQueue<ProcessedDataPacket> OutgoingQueue = new MostRecentDataQueue<ProcessedDataPacket>("TransformedQueue");
        public static Dictionary<int, EventPacket> Events = new Dictionary<int, EventPacket>();

        /// <summary>
        /// THIS IS THE DATA !
        /// </summary>
        public static Root DataRoot { get; set; }

        public static ILog Logger = null;

        static Engine()
        {
            log4net.Config.XmlConfigurator.Configure();
            Logger = log4net.LogManager.GetLogger(typeof(Engine));
            DataRoot = new Root();
        }

        public static void ScheduleProcessing()
        {
            CsvExport exporter =new CsvExport();
            while (1 == 1)
            {
                var item = OutgoingQueue.GetMostRecentData();
                if (item != null)
                {
                    // Do mappings here ...
                    DataRoot.AddPacket(item.Data);
                    exporter.Export(@"Csv/Feeds.csv");
                }
            }
        }

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

                    var doc = TransformXml.XsltTransform(item, Logger);
                    var obj = DeserializeXml.Deserialize(doc, Logger);
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

        public static void ScheduleEvents()
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
                    Logger.Debug(string.Format("Just run load {0}", it.url));
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
                                Logger.Debug(string.Format("Adding feed data to the queue {0}", item.Source));
                                IncomingQueue.AddData(item);
                                runningEvent.Return = null;
                            }

                        }
                        if (runningEvent.Return == null && DateTime.Now > runningEvent.NextRun)
                        {
                            Logger.Debug(string.Format("Next run of {0}", runningEvent.ConfigItem.bookie));
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
                Logger.Fatal(string.Format("LoadXmlFromUrl {0} failed for {1}", it.url, ex.Message));
                return null;
            }
        }
    }
}
