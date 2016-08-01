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

namespace Daw.Services.WindowsService.WebService
{
    [ServiceContract()]
    public interface IEngineWebService
    {
        [OperationContract]
        ThrowAwaySupercededDataQueue<XmlPacket>.StatisticsPacket GetIncomingFeedStatistics();

        [OperationContract]
        ThrowAwaySupercededDataQueue<ProcessedDataPacket>.StatisticsPacket GetProcessingFeedStatistics();
    }
}
