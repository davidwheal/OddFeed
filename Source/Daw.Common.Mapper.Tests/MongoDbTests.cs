using System;
using Daw.Common.Mapper.Entities;
using Daw.Common.Mapper.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daw.Common.Mapper.Tests
{
    [TestClass]
    public class MongoDbTests
    {
        [TestMethod]
        public void InsertARecord()
        {
            var unique1 = Guid.NewGuid().ToString();
            var ev1 = new EventMap()
            {
                Date = DateTime.Now,
                MappedDate = DateTime.UtcNow,
                MappedName = "Event2",
                Name = "NotUnique",
                _id = unique1,
                Priority = AEntity.MapPriorityEnum.High
            };
            var unique2 = Guid.NewGuid().ToString();
            var ev2 = new EventMap()
            {
                Date = DateTime.Now,
                MappedDate = DateTime.UtcNow,
                MappedName = "Event2",
                Name = "NotUnique",
                _id = unique2,
                Priority = AEntity.MapPriorityEnum.Low
            };
            var mh = new MongoHelper<EventMap>("OddFeed", "EventMaps");
            mh.Insert(ev1);
            mh.Insert(ev2);
            var list = mh.Find(unique1);
            Assert.AreEqual(list.Count, 1);
            list = mh.Find(unique2);
            Assert.AreEqual(list.Count, 1);
        }
    }
}
