using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab6.Models;
using Lab6.ViewModels;

namespace Lab6.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
            public string GetString()
            {
                return "Hello World is old now. It’s time for wassup bro ;)";
            }
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }
            vmEmp.UserName = "Admin";
            return View("MyView", vmEmp);
        }
    }
}