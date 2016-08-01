using System.Xml;
using Daw.Common.Configuration;

namespace Daw.Common.CoreData.IncomingData
{
    public class XmlPacket
    {
        public ScheduleConfigItem ConfigItem { get; set; }
        public XmlDocument Xml { get; set; }
    }
}
