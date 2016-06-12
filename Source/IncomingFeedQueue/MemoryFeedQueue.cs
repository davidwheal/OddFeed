using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomingFeedQueue
{
    public class MemoryFeedQueue : IFeedQueue
    {
        private static object lockFlag = new object();


        Queue<object> MyQueue = new Queue<object>();

        #region IFeedQueue Members

        /// <summary>
        /// Remove older sources when adding a new one
        /// </summary>
        /// <param name="item"></param>
        public void AddFeedData(QueueItem item)
        {
            lock (lockFlag)
            {
                bool removedOne = true;
                while (removedOne)
                {
                    removedOne = false;
                    foreach (QueueItem d in MyQueue)
                    {
                        if (d.Source == item.Source)
                        {
                            MyQueue.Dequeue();
                            removedOne = true;
                            break;
                        }
                    }
                }
                MyQueue.Enqueue(item);
            }
        }

        public QueueItem GetMostRecentFeedData()
        {
            lock (lockFlag)
            {
                return (QueueItem)MyQueue.Dequeue(); 
            
            }

        }

        #endregion

        #region IFeedQueue Members


        public int Count()
        {
            return MyQueue.Count;
        }

        #endregion
    }
}
