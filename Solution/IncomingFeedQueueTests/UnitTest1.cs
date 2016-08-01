using System;
using IncomingFeedQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncomingFeedQueueTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddingToQueue()
        {
            QueueItem<int> q1 = new QueueItem<int>("s1", new DateTime(2016, 1, 1, 0, 0, 1), 1);
            QueueItem<int> q2 = new QueueItem<int>("s1", new DateTime(2016, 1, 1, 0, 0, 2), 2);
            QueueItem<int> q3 = new QueueItem<int>("s1", new DateTime(2016, 1, 1, 0, 0, 3), 3);
            ThrowAwaySupercededDataQueue<int> xx = new ThrowAwaySupercededDataQueue<int>("FeedQueue");
            xx.AddData(q1);
            xx.AddData(q2);
            xx.AddData(q3);
            Assert.AreEqual(xx.Count(), 1);

        }

        [TestMethod]
        public void TestAddingToQueue1()
        {
            QueueItem<int> q1 = new QueueItem<int>("s1", new DateTime(2016, 1, 1, 0, 0, 1), 1);
            QueueItem<int> q2 = new QueueItem<int>("s2", new DateTime(2016, 1, 1, 0, 0, 2), 2);
            QueueItem<int> q3 = new QueueItem<int>("s1", new DateTime(2016, 1, 1, 0, 0, 3), 3);
            ThrowAwaySupercededDataQueue<int> xx = new ThrowAwaySupercededDataQueue<int>("TestQueue");
            xx.AddData(q1);
            xx.AddData(q2);
            xx.AddData(q3);
            Assert.AreEqual(xx.Count(), 2);

        }


        [TestMethod]
        public void TestGettingFromQueue()
        {
            QueueItem<int> q1 = new QueueItem<int>("s1", new DateTime(2016, 1, 1, 0, 0, 1), 1);
            QueueItem<int> q2 = new QueueItem<int>("s2", new DateTime(2016, 1, 1, 0, 0, 2), 2);
            QueueItem<int> q3 = new QueueItem<int>("s1", new DateTime(2016, 1, 1, 0, 0, 3), 3);
            ThrowAwaySupercededDataQueue<int> xx = new ThrowAwaySupercededDataQueue<int>("FeedQueue");
            xx.AddData(q1);
            xx.AddData(q2);
            xx.AddData(q3);
            Assert.AreEqual(xx.Count(), 2);
            var xxx = xx.GetMostRecentData();
            Assert.AreEqual((int)xxx.Data, 2);
            xxx = xx.GetMostRecentData();
            Assert.AreEqual((int)xxx.Data, 3);
        }
    }
}
