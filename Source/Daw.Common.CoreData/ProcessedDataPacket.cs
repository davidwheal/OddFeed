using System.Xml;
using Daw.Common.Configuration;
using Daw.Common.Core.Data;

namespace Daw.Common.CoreData
{
    public class ProcessedDataPacket
    {
        public ScheduleConfigItem ConfigItem { get; set; }
        public oddfeed ProcessedObject { get; set; }
    }
}
