using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomingFeedQueue
{
    public interface IThrowAwayQueue<T>
    {
        // Add data from a feed to the queue
        void AddData(QueueItem<T> item);
        // Get the most recent feed data, throwing any old stuff away
        QueueItem<T> GetMostRecentData();
        int Count();
    }
}
