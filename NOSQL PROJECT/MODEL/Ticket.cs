using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class Ticket
    {
        [BsonId]
        public BsonObjectId id { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public BsonDateTime ReportedDate { get; set; }

        [BsonElement("Type")]
        public TicketType TicketType { get; set; } 

        [BsonElement("Employee_Id")]
        public int EmployeeId { get; set; }

        [BsonElement("Priority")]
        public TicketPriority TicketPriority { get; set; }


        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public BsonDateTime Deadline { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Subject")]
        public string Subject { get; set; }

    }
}
