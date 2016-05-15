using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using Daw.Common.Mapper.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Core;


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
        }

        public async Task InsertAsync(T obj)
        {
            await TheCollection.InsertOneAsync(obj,new InsertOneOptions());
        }

        public async Task<List<T>> FindAsync()
        {
            return await TheCollection.Find(Builders<T>.Filter.Empty).ToListAsync();
        }
    }
}
