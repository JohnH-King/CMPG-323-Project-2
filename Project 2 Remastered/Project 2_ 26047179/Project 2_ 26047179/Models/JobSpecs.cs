using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models
{
    public class JobSpecs
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Job Role")]
        [Required]
        public string JobRole { get; set; }

        //add
        [Display(Name = "Hourly Rate")]
        public int HourlyRate { get; set; }

        [Display(Name = "Job Involvement")]
        public string JobInvolvement { get; set; }

        [Display(Name = "Job Level")]
        public int JobLevel { get; set; }

        [Display(Name = "Job Satisfaction")]
        public int JobSatisfaction { get; set; }

        [Display(Name = "Monthly Income")]
        public double MonthlyIncome { get; set; }

        [Display(Name = "Monthyly Rate")]
        public double MonthylyRate { get; set; }

        [Display(Name = "Percent Salary Hike")]
        public int PercentSalaryHike { get; set; }

        [Display(Name = "Standard Hours")]
        public int StandardHours { get; set; }


        //-----

        [Required]
        [Display(Name ="Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
