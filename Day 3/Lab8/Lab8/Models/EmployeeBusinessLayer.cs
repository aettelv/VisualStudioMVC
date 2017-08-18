using System.Collections.Generic;
using Lab8.DataAccessLayer;
using System.Linq;

namespace Lab8.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
    }
}