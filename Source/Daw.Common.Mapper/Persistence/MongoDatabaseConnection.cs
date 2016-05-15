using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Daw.Common.Mapper.Persistence
{
    /// <summary>
    /// The single database object
    /// </summary>
    public static class MongoDatabaseConnection
    {
        public static MongoClient MyClient { get; set; }

        static MongoDatabaseConnection()
        {
            var cn = "mongodb://127.0.0.1:27017";
            MyClient = new MongoClient(cn);
        }
    }
}
