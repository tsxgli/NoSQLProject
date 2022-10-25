using System;
using System.Collections.Generic;
using System.Text;
using MODEL;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class EmployeeDAO:DAO
    {
        public EmployeeDAO()
        {
            
        }
        public Employee GetEmployee(string collection,ObjectId id)
        {
            BsonDocument doc= GetDocumentByObjectId(collection,id);
            Employee employee = new Employee()
            {
                Id = doc["_id"].AsObjectId,
                LastName = doc["FirstName"].ToString(),
                FirstName = doc["FirstName"].ToString(),
                Email=doc["Email"].ToString(),
                UserType=(UserType)Enum.Parse(typeof(UserType),doc["UserType"].ToString()),
                PhoneNumber=doc["PhoneNo"].ToString(),
                Location=doc["Location"].ToString(),
            };
            return employee;
        }

       
    }
}
