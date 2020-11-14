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

        public int Age { get; set; }

        public string Attrition { get; set; }

        [Display(Name = "Businesss Travel")]
        public string BusinessTravel { get; set; }

        [Display(Name = "Daily Rate")]
        public int DailyRate { get; set; }

        public string Department { get; set; }

        [Display(Name = "Distance From Home")]
        public int DistanceFromHome { get; set; }
        public string Education { get; set; }

        [Display(Name = "Education Field")]
        public string EducationField { get; set; }

        [Display(Name = "Employee Count")]
        public int EmployeeCount { get; set; }

        [Display(Name = "Employee Number")]
        [Required]
        public int EmployeeNumber { get; set; }

        [Display(Name = "Environment Satisfaction")]
        public int EnvironmentSatisfaction { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Hourly Rate")]
        public int HourlyRate { get; set; }

        [Display(Name = "Job Involvement")]
        public int JobInvolvement { get; set; }

        [Display(Name = "Job Level")]
        public int JobLevel { get; set; }//could be char

        [Display(Name = "Job Role")]
        public string JobRole { get; set; }

        [Display(Name = "Job Satisfaction")]
        public int JobSatisfaction { get; set; }

        [Display(Name = "Maritial Status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Monthly Income")]
        public int MonthlyIncome { get; set; }

        [Display(Name = "Monthyly Rate")]
        public int MonthlyRate { get; set; }

        [Display(Name = "Number Of Companies Worked")]
        public int NumCompaniesWorked { get; set; }

        [Display(Name = "Over 18? (Y/N)")]
        public char Over18 { get; set; } //Y or N

        [Display(Name = "Overtime (Yes/No)")]
        public string OverTime { get; set; } // Yes/No

        [Display(Name = "Percent Salary Hike")]
        public int PercentSalaryHike { get; set; }

        [Display(Name = "Performance Rating")]
        public int PerformanceRating { get; set; }

        [Display(Name = "Relationship Satisfaction")]
        public int RelationshipSatisfaction { get; set; }

        [Display(Name = "Standard Hours")]
        public int StandardHours { get; set; }

        [Display(Name = "Stock Option Level")]
        public int StockOptionLevel { get; set; }

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

        [Display(Name = "Years Since Last Promotion")]
        public int YearsSinceLastPromotion { get; set; }

        [Display(Name = "Years With Current Manager")]
        public int YearsWithCurrManager { get; set; }

        




    }
}
