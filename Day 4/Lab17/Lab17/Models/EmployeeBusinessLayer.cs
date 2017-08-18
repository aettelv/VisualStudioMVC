using System.Collections.Generic;
using Lab17.DataAccessLayer;
using System.Linq;

namespace Lab17.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }

        public bool IsValidUser(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}