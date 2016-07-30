using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomingFeedQueue
{
    public class MemoryFeedQueue<T> : IFeedQueue<T>
    {

        public class StatisticsPacket
        {
            public int NumberRemoved { get; set; }
            public int NumberEnqueued { get; set; }
            public int NumberDequeued { get; set; }
            public int NumberErrored { get; set; }

            public StatisticsPacket()
            {
                NumberRemoved = 0;
                NumberEnqueued = 0;
                NumberDequeued = 0;
                NumberErrored = 0;
            }

            public void RemoveOne()
            {
                NumberRemoved++;
            }

            public void EnqueuedOne()
            {
                NumberEnqueued++;
            }

            public void DequeuedOne()
            {
                NumberDequeued++;
            }

            public void ErroredOne()
            {
                NumberErrored++;
            }
        }
        private static object lockFlag = new object();


        readonly Queue _myQueue = new Queue();
        public StatisticsPacket Stats = new StatisticsPacket();

        #region IFeedQueue Members

        /// <summary>
        /// Remove older sources when adding a new one
        /// </summary>
        /// <param name="item"></param>
        public void AddFeedData(QueueItem<T> item)
        {
            lock (lockFlag)
            {
                bool removedOne = true;
                while (removedOne)
                {
                    removedOne = false;
                    foreach (QueueItem<T> d in _myQueue)
                    {
                        if (d.Source == item.Source)
                        {
                            _myQueue.Dequeue();
                            removedOne = true;
                            Stats.RemoveOne();
                            break;
                        }
                    }
                }
                Stats.EnqueuedOne();
                _myQueue.Enqueue(item);
            }
        }

        public QueueItem<T> GetMostRecentFeedData()
        {
            lock (lockFlag)
            {
                try
                {
                    Stats.DequeuedOne();
                    return (QueueItem<T>)_myQueue.Dequeue();

                }
                catch (InvalidOperationException ex)
                {
                    // Queue empty
                    Stats.ErroredOne();
                    return null;
                }

            }

        }

        #endregion

        #region IFeedQueue Members


        public int Count()
        {
            return _myQueue.Count;
        }

        #endregion
    }
}
