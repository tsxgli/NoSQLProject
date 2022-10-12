using MODEL;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://682624:1234@cluster0.so0c6ct.mongodb.net/test");
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> databases = new List<Databases_Model>();

            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return databases;
        }
        
        //get collections from database
        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            var database = client.GetDatabase("Project_2_1_NOSQL");
            return database.GetCollection<BsonDocument>(collectionName);
        }

        //add document to collection 
        public void AddDocumentToCollection(BsonDocument document, string collectionName)
        {
            var collection = GetCollection(collectionName);
            collection.InsertOne(document);
        }

    }
}
