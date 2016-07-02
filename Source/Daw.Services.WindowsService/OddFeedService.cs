using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using log4net;
using Timer = System.Threading.Timer;

namespace Daw.Services.WindowsService
{
    public partial class OddFeedService : ServiceBase
    {
        public static ILog Logger = null;
       


        public OddFeedService()
        {
            InitializeComponent();
        }

        

        protected override void OnStart(string[] args)
        {
            // Get feed data
            Task.Run(()=> Engine.ScheduleEvents(Logger));
            // Transform feed data
            Task.Run(()=> Engine.ScheduleTransforms());

        }

        protected override void OnStop()
        {
        }

        public void Process()
        {


            log4net.Config.XmlConfigurator.Configure();
            Logger = log4net.LogManager.GetLogger(this.GetType());
            // Get feed data
            Task.Run(() => Engine.ScheduleEvents(Logger));
            // Transform feed data
            Task.Run(() => Engine.ScheduleTransforms());

        }

    }
}
