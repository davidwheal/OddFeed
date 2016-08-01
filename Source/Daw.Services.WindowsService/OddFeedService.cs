using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Daw.Services.WindowsService.WebService;
using log4net;
using Microsoft.Practices.Unity;
using Timer = System.Threading.Timer;

namespace Daw.Services.WindowsService
{
    public partial class OddFeedService : ServiceBase
    {
        private ServiceHost _engineWebServiceHost;


        public OddFeedService()
        {
            InitializeComponent();
        }




        protected override void OnStop()
        {
            _engineWebServiceHost?.Close();
        }


        public void Process()
        {

            // Get feed data
            Task.Run(() => Engine.ScheduleEvents());
            // Transform feed data
            Task.Run(() => Engine.ScheduleTransforms());
            // Process feed data
            Task.Run(() => Engine.ScheduleProcessing());

            var serviceType = typeof(EngineWebService);
            _engineWebServiceHost = new ServiceHost(serviceType);
            _engineWebServiceHost.Open();

        }

    }
}
