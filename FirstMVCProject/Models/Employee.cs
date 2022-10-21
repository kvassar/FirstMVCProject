using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVCProject.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "Please fill out the required feild.")]
        public int ID { get; set; }
        [Required (ErrorMessage = "Please fill out the required feild.")]
        public string Name { get; set; }
        [Range(100,500,ErrorMessage = "Your salary is not between the range of 100 to 500.")]
        public int Salary { get; set; } 
    }
}