using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models.ViewModels
{
    public class CSVViewModel
    {     
        public int Id { get; set; }
        public int Age { get; set; }
        public string Attrition { get; set; }
        public string BusinessTravel { get; set; }
        public int DailyRate { get; set; }
        public string Department { get; set; }
        public int DistanceFromHome { get; set; }
        public int Education { get; set; }
        public string EducationField { get; set; }
        public int EmployeeCount { get; set; }
        public int EmployeeNumber { get; set; }
        public int EnvironmentSatisfaction { get; set; }
        public string Gender { get; set; }
        public int HourlyRate { get; set; }
        public int JobInvolvement { get; set; }
        public int JobLevel { get; set; }//could be char
        public string JobRole { get; set; }
        public int JobSatisfaction { get; set; }
        public string MaritalStatus { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyRate { get; set; }
        public int NumCompaniesWorked { get; set; }
        public char Over18 { get; set; } //Y or N
        public string OverTime { get; set; } // Yes/No
        public int PercentSalaryHike { get; set; }
        public int PerformanceRating { get; set; }
        public int RelationshipSatisfaction { get; set; }
        public int StandardHours { get; set; }
        public int StockOptionLevel { get; set; }
        public int TotalWorkingYears { get; set; }
        public int TrainingTimesLastYear { get; set; }
        public int WorkLifeBalance { get; set; }
        public int YearsAtCompany { get; set; }
        public int YearsInCurrentRole { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int YearsWithCurrManager { get; set; }
        public JobInfo JobInfo { get; set; }
        public List<string> JobInfoList { get; set; }

        public JobSpecs JobSpecs { get; set; }
        public List<string> JobSpecsList { get; set; }

        public Personal Personal { get; set; }
        public List<string> PersonalList { get; set; }
    }
}
