using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncomingFeedQueue;
using Daw.Common.CoreData;
using Daw.Common.CoreData.IncomingData;
using Daw.Common.CoreData.IntermediateData;
using Daw.Common.CoreData.ProcessorData;

namespace Daw.Common.Interfaces
{
    [ServiceContract()]
    public interface IEngineWebService
    {
        [OperationContract]
        MostRecentDataQueue<XmlPacket>.StatisticsPacket GetIncomingFeedStatistics();

        [OperationContract]
        MostRecentDataQueue<ProcessedDataPacket>.StatisticsPacket GetProcessingFeedStatistics();


        [OperationContract]
        Dictionary<string, BaseFeedDto> GetFeeds();


        [OperationContract]
        Dictionary<string, EventDto> GetEvents(string feedName);
    }
}
