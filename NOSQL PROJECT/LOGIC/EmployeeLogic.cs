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
        private readonly EmployeeDAO employeeDAO;
        public EmployeeLogic()
        {
            employeeDAO = new EmployeeDAO();
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }
        public Employee GetEmployee(string collection, ObjectId id)
        {
            return employeeDAO.GetEmployee(collection, id);
        }


    }
}
