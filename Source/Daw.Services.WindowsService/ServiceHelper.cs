using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Daw.Client.WebServices.Clients;
using Daw.Client.WebServices.Interfaces;
using IncomingFeedQueue;

namespace Daw.Services.WindowsService
{

    public class ScheduleEvent
    {
        public ScheduleConfigItem ConfigItem { get; set; }
        public DateTime NextRun { get; set; }
        public Task<XmlDocument> Return { get; set; }
    }

    public static class ServiceHelper
    {
        public static MemoryFeedQueue<XmlDocument> Queue = new MemoryFeedQueue<XmlDocument>();
        public static Dictionary<int, ScheduleEvent> Events = new Dictionary<int, ScheduleEvent>();

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
                    var task = Task<XmlDocument>.Run(() =>
                    {
                        return LoadXmlFromUrl(client, it);

                    }
                    );
                    Events.Add(i, new ScheduleEvent() { ConfigItem = it, Return = task, NextRun = DateTime.Now.AddSeconds(it.intervalsecs) });
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
                        if (runningEvent.Return.IsCompleted)
                        {
                            XmlDocument x = runningEvent.Return.Result;
                            if (x != null)
                            {
                                var item = new QueueItem<XmlDocument>(it.bookie, DateTime.Now, x);
                                Queue.AddFeedData(item);
                            }
                            if (DateTime.Now > runningEvent.NextRun)
                            {
                                runningEvent.Return = Task<XmlDocument>.Run(() =>
                                {
                                    return LoadXmlFromUrl(client, it);

                                });
                                runningEvent.NextRun = DateTime.Now.AddSeconds(it.intervalsecs);
                            }
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
                OddFeedScheduler.Logger.Fatal(string.Format("LoadXmlFromUrl {0} failed for {1}", it.url, ex.Message));
                return null;
            }
        }
    }
}
