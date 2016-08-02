using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Configuration;
using Daw.Common.CoreData.IntermediateData;

namespace Daw.Common.CoreData.ProcessorData
{
    /// <summary>
    /// All processed data starts from here
    /// </summary>
    public class Root : ConcurrentDictionary<string, BaseFeed>
    {
        private Object thisLock = new Object();
        public void AddPacket(ProcessedDataPacket packet)
        {
            lock (thisLock)
            {
                BaseFeed item;
                if (TryGetValue(packet.ConfigItem.CalcKey(), out item))
                {
                    item.Assimilate(packet.ProcessedObject);
                }
                else
                {
                    TryAdd(packet.ConfigItem.CalcKey(), new BaseFeed(packet.ProcessedObject, packet.ConfigItem));
                }
            }
        }


    }
}
