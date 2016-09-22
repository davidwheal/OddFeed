using System;
using MongoDB.Driver;

namespace Daw.Common.Mapper
{
    public static class Mapper
    {
        public static void MapEvent(string name, DateTime? date, string mappedName, DateTime? mappedDate)
        {
            // MongoDb!!!!!!!!!!
            // Look for a regex in the table that works
            var client = new MongoClient();
            var database = client.GetDatabase("EventMappings");
        }
    }
}
