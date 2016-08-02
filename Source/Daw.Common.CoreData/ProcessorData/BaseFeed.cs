using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Daw.Common.Configuration;

namespace Daw.Common.CoreData.ProcessorData
{
    [DataContract]
    public class BaseFeedDto
    {
        [DataMember]
        public string Sport { get; set; }
        [DataMember]
        public string FeedName { get; set; }
        [DataMember]
        public bool FixturesOnly { get; set; }

        public BaseFeedDto()
        {
        }

    }

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
