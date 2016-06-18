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
    public partial class OddFeedScheduler : ServiceBase
    {
        public static ILog Logger = null;
        private System.Timers.Timer _timer1 = null;


        public OddFeedScheduler()
        {
            InitializeComponent();
        }

        private void timer1_tick(object sender, ElapsedEventArgs e)
        {
            ServiceHelper.ScheduleEvents();
        }

        protected override void OnStart(string[] args)
        {
            _timer1 = new System.Timers.Timer();
            _timer1.Interval = 300;
            _timer1.Elapsed += timer1_tick;
            _timer1.Enabled = true;
        }

        protected override void OnStop()
        {
        }

        public void Process()
        {


            log4net.Config.XmlConfigurator.Configure();
            Logger = log4net.LogManager.GetLogger(this.GetType());
            ServiceHelper.ScheduleEvents();

        }

    }
}
