using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomingFeedQueue
{
    public class MostRecentDataQueue<T> : IThrowAwayQueue<T>
    {
        public class StatisticsPacket
        {
            public int NumberRemoved { get; set; }
            public int NumberEnqueued { get; set; }
            public int NumberDequeued { get; set; }
            public int NumberErrored { get; set; }

            private string Name { get; set; }

            public override string ToString()
            {
                return string.Format("Enqueued {0} Dequeued {1} Discarded {2} Empty {3}", NumberEnqueued, NumberDequeued,
                    NumberRemoved, NumberErrored);
            }

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
        public MostRecentDataQueue(string name)
        {
            Name = name;
        }

        private static object lockFlag = new object();
        public string Name { get; set; }

        readonly Queue _myQueue = new Queue();
        public StatisticsPacket Stats = new StatisticsPacket();

        #region IThrowAwayQueue Members

        /// <summary>
        /// Remove older sources when adding a new one
        /// </summary>
        /// <param name="item"></param>
        public void AddData(QueueItem<T> item)
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
                            Console.WriteLine(Stats);
                            break;
                        }
                    }
                }
                Stats.EnqueuedOne();
                _myQueue.Enqueue(item);
                Console.WriteLine(Stats);
            }
        }

        public QueueItem<T> GetMostRecentData()
        {
            lock (lockFlag)
            {
                try
                {
                    Console.WriteLine(Stats);
                    var result = (QueueItem<T>)_myQueue.Dequeue();
                    Stats.DequeuedOne();
                    return result;
                }
                catch (InvalidOperationException ex)
                {
                    // Queue empty
                    Stats.ErroredOne();
                    Console.WriteLine(Stats);
                    return null;
                }

            }

        }

        #endregion

        #region IThrowAwayQueue Members


        public int Count()
        {
            return _myQueue.Count;
        }

        #endregion
    }
}
