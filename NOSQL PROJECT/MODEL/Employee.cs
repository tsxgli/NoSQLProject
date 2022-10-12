using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MODEL
{
    public class Employee
    {
        [BsonId]
        public BsonObjectId Id { get; set; }


        [BsonElement("name")]
        public BsonDocument Name = new BsonDocument();

        [BsonElement("Last_Name")]
        public String LastName { get; set; }

        [BsonElement("Type")]
        public UserType UserType { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Phone_Number")]
        public string PhoneNumber { get; set; }

        [BsonElement("Location")]

        public string Location { get; set; }

    }
}
