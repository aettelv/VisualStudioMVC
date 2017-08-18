using Lab14.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Lab14.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [FirstNameValidation]
        public string FirstName { get; set; }

        [StringLength(5, ErrorMessage = "Last Name length should not be greater than 5")]
        public string LastName { get; set; }
        public int Salary { get; set; }

    }
}