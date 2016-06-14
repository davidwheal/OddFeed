using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Daw.Client.WebServices.Clients;

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
        public static Dictionary<int, ScheduleEvent> Events = new Dictionary<int, ScheduleEvent>();

        public static void ScheduleEvents()
        {
            SecretClient sc = new SecretClient();
            var client = sc.Open();
            var scConfig = SchedulerConfigSection.Instance.Schedules;
            // Load up the tasks
            for (int i = 0; i <= scConfig.Count; i++)
            {
                ScheduleConfigItem it = scConfig.GetItemAt(i);
                if (it.type == "xml")
                {
                    var task = Task<XmlDocument>.Run(() => client.LoadXmlFromUrl(it.url));
                    Events.Add(i, new ScheduleEvent() { ConfigItem = it, Return = task, NextRun = DateTime.Now.AddSeconds(it.intervalsecs) });
                }
            }
            // Run them for a bit
            for (int i = 0; i <= scConfig.Count; i++)
            {
                ScheduleConfigItem it = scConfig.GetItemAt(i);
                if (it.type == "xml")
                {
                    var runningEvent = Events[i];
                    if (runningEvent.Return.IsCompleted)
                    {
                        XmlDocument x = runningEvent.Return.Result;
                        if (DateTime.Now>runningEvent.NextRun)
                        {
                            var task = Task<XmlDocument>.Run(() => client.LoadXmlFromUrl(it.url));
                            runningEvent.Return = task;
                        }
                    }
                }
            }
            sc.Close(client);
        }
    }
}
