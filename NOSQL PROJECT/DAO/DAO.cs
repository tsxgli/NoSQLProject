using MODEL;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DAL
{
    public abstract class DAO
    {
        protected MongoClient client;
        protected IMongoDatabase db;

        //strings for inserting records into the table
        protected string ticketCollection = "Tickets";
        protected string employeeCollection = "Employees";

        public DAO()
        {
            client = new MongoClient("mongodb+srv://682624:1234@cluster0.so0c6ct.mongodb.net/test");
            IMongoDatabase db = client.GetDatabase("studentDB");
        }

        protected List<Databases_Model> GetDatabases()
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
        protected void InsertRecord(string collectionName, BsonDocument doc)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(doc);
        }
    }
}
