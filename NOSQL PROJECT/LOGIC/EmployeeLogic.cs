using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using MODEL;
using MongoDB.Bson;

namespace LOGIC
{
    public class EmployeeLogic
    {
        private EmployeeDAO employeeDAO;
        public List<Employee> GetAllEmployees(List<BsonDocument> docs)
        {
            return employeeDAO.GetAllEmployees(docs);
        }
        
    }
}
