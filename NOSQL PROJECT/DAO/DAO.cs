using MODEL;
using MongoDB.Driver;
using System;

namespace DAO
{
    public class Dao
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Project_2_1_NOSQL");

        //get ticket collection
        static IMongoCollection<Ticket> ticketCollection = db.GetCollection<Ticket>("Tickets");

        //get employee collection
        static IMongoCollection<Employee> employeeCollection = db.GetCollection<Employee>("Employees");
    }
}
