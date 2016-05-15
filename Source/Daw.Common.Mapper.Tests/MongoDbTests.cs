using System;
using System.Threading.Tasks;
using Daw.Common.Mapper.Entities;
using Daw.Common.Mapper.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daw.Common.Mapper.Tests
{
    [TestClass]
    public class MongoDbTests
    {
        [TestMethod]
        public async  Task InsertARecord()
        {
            var unique1 = Guid.NewGuid().ToString();
            var ev1 = new EventMap()
            {
                MappedDate = DateTime.UtcNow,
                MappedName = "Event2",
                _id = unique1,
                RegexPattern = "dfdf"
            };
            var unique2 = Guid.NewGuid().ToString();
            var ev2 = new EventMap()
            {
                MappedDate = DateTime.UtcNow,
                MappedName = "Event2",
                _id = unique2,
                RegexPattern = "dfdf"
            };
            var mh = new MongoHelper<EventMap>("OddFeed", "EventMaps");
            await mh.InsertAsync(ev1);
            await mh.InsertAsync(ev2);
            var list = await mh.FindAsync();

            Assert.IsTrue(list.Count > 0);
        }
    }
}
