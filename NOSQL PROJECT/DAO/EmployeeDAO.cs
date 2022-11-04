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
        public Employee GetEmployee( ObjectId id)
        {
            var collection = base.GetCollection(employeeCollection);
            Employee employee = new Employee();

            var filter = Builders<Employee>.Filter.Eq("_id", id);
            var document = collection.Find(filter).ToList();

            return employee;
        }
        public List<Employee> GetAllEmployees(List<BsonDocument> do3cs)
        {
            var collection = base.GetCollection(employeeCollection);
            docs=collection.Find(new BsonDocument()).ToList();
            List<Employee> employees = new List<Employee>();

            foreach (var doc in docs)
            {
                Employee employee = BsonSerializer.Deserialize<Employee>(doc);
                employees.Add(employee);
            };
            return employees;
        }
    }


}

