using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Lab17.Models;
using Lab17.ViewModels;

namespace Lab17.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Hello World is old now. It’s time for wassup bro ;)";
        }

        [Authorize]
        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            return View("Index", employeeListViewModel);
        }
        public ActionResult AddNew()
        {
            return View("CreateEmployee", new CreateEmployeeViewModel());
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        CreateEmployeeViewModel vm = new CreateEmployeeViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;
                        if (e.Salary > 0)
                        {
                            vm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            vm.Salary = ModelState["Salary"].Value.AttemptedValue;
                        }
                        return View("CreateEmployee", vm);
                    }
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
        public class MyEmployeeModelBinder : DefaultModelBinder
        {
            protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
            {
                Employee e = new Employee();
                e.FirstName = controllerContext.RequestContext.HttpContext.Request.Form["FName"];
                e.LastName = controllerContext.RequestContext.HttpContext.Request.Form["LName"];
                e.Salary = int.Parse(controllerContext.RequestContext.HttpContext.Request.Form["Salary"]);
                return e;
            }

        }
    }
}