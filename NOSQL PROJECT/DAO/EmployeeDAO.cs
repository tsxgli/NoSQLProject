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
        public EmployeeDAO()
        {

        }

        public List<Employee> GetAllEmployees()
        {
            //return ReadEmployee(GetAll(employeeCollection));
            try
            {
                List<Employee> employees = new List<Employee>();
                var collection = base.GetCollection(employeeCollection);
                var documents = collection.Find(new BsonDocument()).ToList();

                foreach (BsonDocument doc in documents)
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
                        NoTicketsReported = (int)doc["NoTicketsReported"],
                        Password = doc["Password"].ToString(),
                    };
                    employees.Add(employee);
                }

                return employees;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Something went wrong while getting all employees:{e.Message}");

            }

        }

        public void AddNewEmployeeToDatabase(Employee employee)
        {
            try
            {
                BsonDocument doc = new BsonDocument();

                doc["First Name"] = employee.FirstName;
                doc["LastName"] = employee.LastName;
                doc["UserType"] = employee.UserType;
                doc["Email"] = employee.Email;
                doc["PhoneNo"] = employee.PhoneNumber;
                doc["Location/Branch"] = employee.Location;
                doc["NoTicketsReported"] = 0;
                doc["Password"] = employee.Password;
                doc["Username"] = employee.Username;


                InsertRecord(employeeCollection, doc);
            }
            catch (Exception e)
            {

                throw new ArgumentException($"There was something wrong when adding new employee: {e.Message}");
            }

        }

        public Employee GetEmployee(string collection, ObjectId id)
        {
            try
            {
                BsonDocument doc = GetDocumentByObjectId(collection, id);
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
                    NoTicketsReported = (int)doc["NoTicketsReported"],
                    Password = doc["Password"].ToString(),
                };
                return employee;
            }
            catch (Exception e)
            {

                throw new ArgumentException($"Something went wrong when getting the employee: {e.Message} ");
            }

        }
        public void UpdateEmployee(Employee employee)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", employee.Id);
                var update = Builders<BsonDocument>.Update.Set("First Name", employee.FirstName)
                                                            .Set("LastName", employee.LastName)
                                                            .Set("UserType", employee.UserType)
                                                            .Set("Username", employee.Username)
                                                            .Set("PhoneNo", employee.PhoneNumber)
                                                            .Set("Location/Branch", employee.Location)
                                                            .Set("Password", employee.Password)
                                                            .Set("NoTicketsReported", employee.NoTicketsReported);
                GetCollection(employeeCollection).UpdateOne(filter, update);
            }
            catch (Exception e)
            {
                throw new Exception($"Something went wrong when updating user:{e.Message} ");
            }

        }

        //method to update the password of an employee
        public void UpdateEmployeePassword(Employee employee, string newPassword)
        {
            //get the if of the employee for the filter
            var filter = Builders<BsonDocument>.Filter.Eq("_id", employee.Id);

            //get the new password
            var update = Builders<BsonDocument>.Update.Set("Password", newPassword);

            //update the password
            GetCollection(employeeCollection).UpdateOne(filter, update);
        }


        public List<Employee> GetEmployeeByEmail(string letters)
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                var filter = Builders<BsonDocument>.Filter.Regex("Email", letters);
                var list = GetCollection(employeeCollection).Find(filter).ToList();
                foreach (var doc in list)
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
                        NoTicketsReported = (int)doc["NoTicketsReported"],
                        Password = doc["Password"].ToString(),
                    };
                    employees.Add(employee);
                }
                return employees;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Something went wrong when getting user: {e.Message} ");
            }
        }

    }



}

