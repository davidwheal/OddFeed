using Daw.Common.Configuration;

namespace Daw.Common.CoreData.IntermediateData
{
    public class ProcessedDataPacket
    {
        public ScheduleConfigItem ConfigItem { get; set; }
        public oddfeed ProcessedObject { get; set; }
    }
}
