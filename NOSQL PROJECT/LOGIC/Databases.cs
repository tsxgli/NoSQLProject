using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using MODEL;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LOGIC
{
    public class Databases
    {
        private DAO dao;

        public Databases()
        {
            dao = new DAO();
        }

        public List<Databases_Model> GetDatabases()
        {
            return dao.GetDatabases();
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return dao.GetCollection(collectionName);
        }

        public void AddDocumentToCollection(BsonDocument document, string collectionName)
        {
            dao.AddDocumentToCollection(document, collectionName);
        }
    }

}
