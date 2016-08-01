using Daw.Common.CoreData;
using Daw.Common.CoreData.IncomingData;
using Daw.Common.CoreData.IntermediateData;
using IncomingFeedQueue;
using log4net;

namespace Daw.Services.WindowsService.WebService
{
    public class EngineWebService : IEngineWebService
    {
        //private ILog _logger = null;
        //public EngineWebService(ILog logger)
        //{
        //    _logger = logger;
        //}
        public ThrowAwaySupercededDataQueue<XmlPacket>.StatisticsPacket GetIncomingFeedStatistics()
        {
            return Engine.IncomingQueue.Stats;
        }

        public ThrowAwaySupercededDataQueue<ProcessedDataPacket>.StatisticsPacket GetProcessingFeedStatistics()
        {
            return Engine.OutgoingQueue.Stats;
        }
        
    }
}