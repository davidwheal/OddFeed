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
            QueueItem q1 = new QueueItem("s1", new DateTime(2016, 1, 1, 0, 0, 1), (object)1);
            QueueItem q2 = new QueueItem("s1", new DateTime(2016, 1, 1, 0, 0, 2), (object)2);
            QueueItem q3 = new QueueItem("s1", new DateTime(2016, 1, 1, 0, 0, 3), (object)3);
            MemoryFeedQueue xx = new MemoryFeedQueue();
            xx.AddFeedData(q1);
            xx.AddFeedData(q2);
            xx.AddFeedData(q3);
            Assert.AreEqual(xx.Count(), 1);

        }

        [TestMethod]
        public void TestAddingToQueue1()
        {
            QueueItem q1 = new QueueItem("s1", new DateTime(2016, 1, 1, 0, 0, 1), (object)1);
            QueueItem q2 = new QueueItem("s2", new DateTime(2016, 1, 1, 0, 0, 2), (object)2);
            QueueItem q3 = new QueueItem("s1", new DateTime(2016, 1, 1, 0, 0, 3), (object)3);
            MemoryFeedQueue xx = new MemoryFeedQueue();
            xx.AddFeedData(q1);
            xx.AddFeedData(q2);
            xx.AddFeedData(q3);
            Assert.AreEqual(xx.Count(), 2);

        }


        [TestMethod]
        public void TestGettingFromQueue()
        {
            QueueItem q1 = new QueueItem("s1", new DateTime(2016, 1, 1, 0, 0, 1), (object)1);
            QueueItem q2 = new QueueItem("s2", new DateTime(2016, 1, 1, 0, 0, 2), (object)2);
            QueueItem q3 = new QueueItem("s1", new DateTime(2016, 1, 1, 0, 0, 3), (object)3);
            MemoryFeedQueue xx = new MemoryFeedQueue();
            xx.AddFeedData(q1);
            xx.AddFeedData(q2);
            xx.AddFeedData(q3);
            Assert.AreEqual(xx.Count(), 2);
            var xxx = xx.GetMostRecentFeedData();
            Assert.AreEqual((int)xxx.Data, 2);
            xxx = xx.GetMostRecentFeedData();
            Assert.AreEqual((int)xxx.Data, 3);
        }
    }
}
