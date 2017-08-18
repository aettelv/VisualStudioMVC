using Lab16.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Lab16.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [FirstNameValidation]
        public string FirstName { get; set; }

        [StringLength(5, ErrorMessage = "Last Name length should not be greater than 5")]
        public string LastName { get; set; }

        [Range(typeof(int), "5000", "50000", ErrorMessage = "Put a proper Salary value between 5000 and 50000")]
        public int Salary { get; set; }

    }
}