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
                LastName = doc["LastName"].ToString(),
                FirstName = doc["First Name"].ToString(),
                Email=doc["Email"].ToString(),
                UserType=(UserType)Enum.Parse(typeof(UserType),doc["UserType"].ToString()),
                PhoneNumber=doc["PhoneNo"].ToString(),
                Location=doc["Location"].ToString(),
            };
            return employee;
        }
        private List<Employee> GetIncidents(List<BsonDocument> docs) //get all incidents
        {
            List<Employee> employees = new List<Employee>();

            foreach (var doc in docs)
            {
                Employee employee = new Employee()
                {
                    Id = doc["_id"].AsObjectId,
                    LastName = doc["LastName"].ToString(),
                    FirstName = doc["First Name"].ToString(),
                    Email = doc["Email"].ToString(),
                    UserType = (UserType)Enum.Parse(typeof(UserType), doc["UserType"].ToString()),
                    PhoneNumber = doc["PhoneNo"].ToString(),
                    Location = doc["Location"].ToString(),

                };
                employees.Add(employee);
            }
            return employees;
        }


    }
}
