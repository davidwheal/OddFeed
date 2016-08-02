using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Configuration;

namespace Daw.Common.CoreData.ProcessorData
{
    public class BaseFeed
    {
        public Sport TheSport { get; set; }
        public ScheduleConfigItem TheFeedDefinition { get; set; }

        public BaseFeed(oddfeed feedObject, ScheduleConfigItem feedDefinition)
        {
            TheFeedDefinition = feedDefinition;
            TheSport = new Sport(feedObject);
        }

        public void Assimilate(oddfeed feedObject)
        {
            TheSport.Assimilate(feedObject);
        }

    }

}
