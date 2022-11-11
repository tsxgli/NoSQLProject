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
            //create connection to db
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

        public void AddNewEmployeeToDatabase(Employee employee)
        {
             employeeDAO.AddNewEmployeeToDatabase(employee);
        }
            
        public void UpdateEmployee(Employee employee)
        {
            employeeDAO.UpdateEmployee(employee);   
        }

        //method to update the password of an employee
        public void UpdateEmployeePassword(Employee employee, string newPassword)
        {
            employeeDAO.UpdateEmployeePassword(employee, newPassword);
        }
    }
}
