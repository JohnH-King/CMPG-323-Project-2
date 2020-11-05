using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_2__26047179.Models
{
    public class JobInfo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Education Field")]
        [Required]
        public string EducationField { get; set; }


        //add

        public string Education { get; set; }

        [Display(Name = "Number Of Companies Worked")]
        public int NumCompaniesWorked { get; set; }

        [Display(Name = "Total Working Years")]
        public int TotalWorkingYears { get; set; }

        [Display(Name = "Training Times Last Year")]
        public int TrainingTimesLastYear { get; set; }

        [Display(Name = "Work Life Balance")]
        public int WorkLifeBalance { get; set; }

        [Display(Name = "Years At Company")]
        public int YearsAtCompany { get; set; }

        [Display(Name = "Years In Current Role")]
        public int YearsInCurrentRole { get; set; }

        [Display(Name = "Years With Current Manager")]
        public int YearsWithCurrManager { get; set; }


        //-----

        [Required]
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
