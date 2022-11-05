using System;
using System.Collections.Generic;
using System.Text;
using MODEL;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Linq;

namespace DAL
{
    public class EmployeeDAO : DAO
    {
        public Employee GetEmployee( ObjectId id)
        {
            var collection = base.GetCollection(employeeCollection);
            Employee employee = new Employee();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var document = collection.Find(filter).ToList();

            return employee;
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            var collection = base.GetCollection(employeeCollection);
            var documents = collection.Find(new BsonDocument()).ToList();

            foreach(BsonDocument doc in documents)
            {
                /*Employee employee = new Employee()
                {
                    Id = doc["_id"].AsObjectId,
                    FirstName = doc["First Name"].ToString(),
                    LastName = doc["LastName"].ToString(),
                    UserType = (UserType)Enum.Parse(typeof(UserType), doc["UserType"].ToString()),
                    Email = doc["Email"].ToString(),
                    PhoneNumber = doc["PhoneNo"].ToString(),
                    Location = doc["Location/Branch"].ToString(),
                    NoTicketsReported = (int)doc["NoTicketsReported"],
                    Password = doc["Password"].ToString(),
                    Username = doc["Username"].ToString()
                };
                employees.Add(employee);*/

                Employee employee = BsonSerializer.Deserialize<Employee>(doc);
                employees.Add(employee);

            }

            return employees;
        }
    }


}

