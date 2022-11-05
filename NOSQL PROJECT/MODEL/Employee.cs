using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MODEL
{
    public class Employee
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("First Name")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("UserType")]
        public UserType UserType { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("PhoneNo")]
        public string PhoneNumber { get; set; }

        [BsonElement("Location/Branch")]
        public string Location { get; set; }

        [BsonElement("NoTicketsReported")]
        public int NoTicketsReported { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; }
    }
}
