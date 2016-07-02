using System.Xml;
using Daw.Common.Configuration;

namespace Daw.Common.CoreData
{
    public class XmlFeedPacket
    {
        public ScheduleConfigItem ConfigItem { get; set; }
        public XmlDocument XmlFromFeed { get; set; }
    }
}
