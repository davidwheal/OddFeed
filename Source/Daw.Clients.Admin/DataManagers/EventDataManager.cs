using Daw.Common.CoreData.ProcessorData;
using Daw.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Clients.Admin.DataManagers
{
    public static class EventDataManager
    {
        public static Dictionary<string, EventDto> GetEvents(string eventKey)
        {
            return (FeedDataManager.Engine()).GetEvents(eventKey);
        }
    }
}
