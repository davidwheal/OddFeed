using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daw.Services.WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if (!DEBUG)
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new OddFeedService() 
            };
            ServiceBase.Run(ServicesToRun);
#else
            var serv = new OddFeedService();
            serv.Process();
            while (1 == 1)
            {
                Thread.Sleep(1000);
            }
#endif
        }
    }
}
