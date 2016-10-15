using Daw.Client.WebServices.Clients;
using Daw.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Clients.Admin.DataManagers
{
    public static class FeedDataManager
    {
        public static IEngineWebService engineService = null;

        public static IEngineWebService Engine ()
        {
            if (engineService == null)
            {
                while (1 == 1)
                {
                    var sc = new EngineClient();
                    try
                    {
                        engineService = sc.Open();
                        return engineService;
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return engineService;
        }
    }
}
