using System.Collections.Generic;
using Lab10.DataAccessLayer;
using System.Linq;

namespace Lab10.Models
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