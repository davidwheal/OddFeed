﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomingFeedQueue
{
    public interface IFeedQueue<T>
    {
        // Add data from a feed to the queue
        void AddFeedData(QueueItem<T> item);
        // Get the most recent feed data, throwing any old stuff away
        QueueItem<T> GetMostRecentFeedData();
        int Count();
    }
}