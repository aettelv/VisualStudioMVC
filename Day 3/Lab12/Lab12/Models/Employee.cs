using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Lab12.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

    }
}