using System.Collections.Generic;
using System.Dynamic;
using Daw.Common.Mapper.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Daw.Common.Mapper.Persistence
{
    /// <summary>
    /// https://www.mongodb.com/dr/fastdl.mongodb.org/win32/mongodb-win32-x86_64-2008plus-ssl-3.2.6-signed.msi/download
    /// http://mongodb.github.io/mongo-csharp-driver/2.2/reference/driver/connecting/
    /// </summary>
    public class MongoHelper<T> where T : AEntity
    {
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
        private IMongoCollection<T> TheCollection { get; set; }

        public MongoHelper(string databaseName, string collectionName)
        {
            BsonClassMap.RegisterClassMap<T>();
            DatabaseName = databaseName;
            CollectionName = collectionName;
            TheCollection = MongoDatabaseConnection.MyClient.GetDatabase(databaseName).GetCollection<T>(collectionName);
            // Index on the unmapped name
            TheCollection.Indexes.CreateOne(Builders<T>.IndexKeys.Ascending(x => x.Name));
        }

        public void Insert(T obj)
        {
            TheCollection.InsertOne(obj,new InsertOneOptions());
        }

        public List<T> Find(string name)
        {
            var builder = new FilterDefinitionBuilder<T>();
            var filter = builder.Eq(x=>x.Name, name);
            return TheCollection.FindSync(filter).ToList();
        }
    }
}
