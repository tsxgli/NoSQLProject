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
        
        public IncidentDAO() { 
     
        }

        public void AddNewIncident(Ticket incident)
        {
            //creates new document
            BsonDocument doc = new BsonDocument();

            doc["Subject"] = incident.Subject;

            doc["Priority"] = incident.TicketPriority.ToString();

            doc["Deadline"] = incident.Deadline;

            doc["IncidentType"] = incident.TicketType.ToString();

            doc["UserReported"] = incident.UserReported.Id;

            doc["Description"] = incident.Description;

            doc["ReportedDate"] = incident.ReportedDate;

            //inserts document into ticketcollection
            InsertRecord(ticketCollection, doc);
        }

        private List<Ticket> GetIncidents(List<BsonDocument> docs) //get all incidents
        {
            List<Ticket> incidents = new List<Ticket>();

            foreach (var doc in docs)
            {
                Ticket ticket = new Ticket()
                {
                    id = doc["_id"].AsObjectId,
                    Subject = doc["Subject"].ToString(),
                    ReportedDate = DateTime.Parse(doc["ReportedDate"].ToString()),
                    TicketPriority = (TicketPriority)Enum.Parse(typeof(TicketPriority), doc["Priority"].ToString()),
                    UserReported = GetEmployee((ObjectId)doc["UserReported"]),
                    TicketType = (TicketType)Enum.Parse(typeof(TicketType), doc["IncidentType"].ToString()),
                    Description = doc["Description"].ToString(),
                    Deadline = DateTime.Parse(doc["Deadline"].ToString()),
                    TicketStatus = (TicketStatus)Enum.Parse(typeof(TicketStatus), doc["Status"].ToString())
                };
                incidents.Add(ticket);
            }
            return incidents;
        }
        private Employee GetEmployee(ObjectId id)
        {
            EmployeeDAO employeeDAO= new EmployeeDAO();
            return employeeDAO.GetEmployee("Employees", id);
        }
    }
}
