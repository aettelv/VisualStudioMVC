using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
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

            ViewBag.Employee = emp;
            return View("MyView");
        }
    }
}
