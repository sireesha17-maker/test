using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Display(Name ="Employee Id")]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }
}