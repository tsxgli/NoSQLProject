﻿using System;
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
        public EmployeeDAO()
        {

        }

        public List<Employee> GetAllEmployees()
        {
            return ReadEmployee(GetAll(employeeCollection));
        }
        public List<Employee> ReadEmployee(List<BsonDocument> collection)
        {
            List<Employee> employees = new List<Employee>();

            foreach (var doc in collection)
            {
                Employee employee = new Employee
                {
                    Id = doc["_id"].AsObjectId,
                    FirstName = doc["First Name"].ToString(),
                    LastName = doc["LastName"].ToString(),
                    Email = doc["Email"].ToString(),
                    Username = doc["Username"].ToString(),
                    UserType = (UserType)Enum.Parse(typeof(UserType), doc["UserType"].ToString()),
                    PhoneNumber = doc["PhoneNo"].ToString(),
                    Location = doc["Location/Branch"].ToString(),
                    Password = doc["Password"].ToString(),
                };
                employees.Add(employee);
            }

            return employees;
        }

        public void AddNewEmployeeToDatabase(Employee employee)
        {
            BsonDocument doc = new BsonDocument();

            doc["First Name"] = employee.FirstName;
            doc["LastName"]=employee.LastName;
            doc["UserType"] = employee.UserType;
            doc["Email"]=employee.Email;
            doc["PhoneNo"] = employee.PhoneNumber;
            doc["Location/Branch"] = employee.Location;
            doc["NoTicketsReported"] = 0;
            doc["Password"] = employee.Password;
            doc["Username"] = employee.Username;


            InsertRecord(employeeCollection, doc);
        }

        public Employee GetEmployee(string collection,ObjectId id)
        {
            BsonDocument doc = GetDocumentByObjectId(collection,id);
            Employee employee = new Employee
            {
                Id = doc["_id"].AsObjectId,
<<<<<<< HEAD
                LastName = doc["LastName"].ToString(),
                FirstName = doc["First Name"].ToString(),
                Email=doc["Email"].ToString(),
                UserType=(UserType)Enum.Parse(typeof(UserType),doc["UserType"].ToString()),
                PhoneNumber=doc["PhoneNo"].ToString(),
                Location=doc["Location"].ToString(),
=======
                FirstName = doc["First Name"].ToString(),
                LastName = doc["LastName"].ToString(),
                Email = doc["Email"].ToString(),
                Username = doc["Username"].ToString(),
                UserType = (UserType)Enum.Parse(typeof(UserType), doc["UserType"].ToString()),
                PhoneNumber = doc["PhoneNo"].ToString(),
                Location = doc["Location/Branch"].ToString(),
                Password = doc["Password"].ToString(),
>>>>>>> main
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

