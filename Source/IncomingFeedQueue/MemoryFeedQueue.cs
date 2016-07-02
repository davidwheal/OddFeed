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
        private static object lockFlag = new object();


        readonly Queue _myQueue = new Queue();

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
                            break;
                        }
                    }
                }
                _myQueue.Enqueue(item);
            }
        }

        public QueueItem<T> GetMostRecentFeedData()
        {
            lock (lockFlag)
            {
                try
                {
                    return (QueueItem<T>)_myQueue.Dequeue();

                }
                catch (InvalidOperationException ex)
                {
                    // Queue empty
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
