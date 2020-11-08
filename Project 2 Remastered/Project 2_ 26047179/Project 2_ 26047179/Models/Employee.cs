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
        public int EmployeeNumber { get; set; }

        public string Department { get; set; }

        [Display(Name = "Employee Count")]
        public int EmployeeCount { get; set; }

        [Display(Name = "Environment Satisfaction")]
        public int EnvironmentSatisfaction { get; set; }
        public char Overtime { get; set; }

        [Display(Name = "Performance Rating")]
        public int PerformanceRating { get; set; }

        [Display(Name = "Stock Option Level")]
        public int StockOptionLevel { get; set; }

    }
}
