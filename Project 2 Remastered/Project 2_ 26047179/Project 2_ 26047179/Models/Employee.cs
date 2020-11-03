using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Employee Number")]
        [Required]
        public string EmployeeNumber { get; set; }

        public string Department { get; set; }
        public int EmployeeCount { get; set; }
        public int EnvironmentSatisfaction { get; set; }
        public char Overtime { get; set; }
        public int PerformanceRating { get; set; }
        public int StockOptionLevel { get; set; }

    }
}
