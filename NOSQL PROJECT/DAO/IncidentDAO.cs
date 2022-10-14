using MODEL;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class IncidentDAO: DAO
    {

        public IMongoCollection<Ticket> collection;
        
        public IncidentDAO()
        {
            client = new MongoClient("mongodb+srv://682624:1234@cluster0.so0c6ct.mongodb.net/test");
            IMongoDatabase db = client.GetDatabase("studentDB");
            collection = db.GetCollection<Ticket>("Tickets");
        }

        public void AddNewIncident(Ticket incident)
        {
            //creates new document
            BsonDocument doc = new BsonDocument();

            doc["Subject"] = incident.Subject;

            doc["Priority"] = incident.TicketPriority.ToString();

            doc["Deadline"] = incident.Deadline;

            doc["IncidentType"] = incident.TicketType.ToString();

            doc["UserReported"] = incident.EmployeeId;

            doc["Description"] = incident.Description;

            doc["ReportedDate"] = incident.ReportedDate;

            //inserts document into ticketcollection
            InsertRecord(ticketCollection, doc);
        }

       
    }
}
