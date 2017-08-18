using System.Collections.Generic;
using Lab11.DataAccessLayer;
using System.Linq;

namespace Lab11.Models
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