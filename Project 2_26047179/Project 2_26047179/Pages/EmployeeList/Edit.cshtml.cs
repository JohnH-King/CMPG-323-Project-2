using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project_2_26047179.Model;

namespace Project_2_26047179.Pages.EmployeeList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task OnGet(int id)
        {
            Employee = await _db.Employee.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {//update in db
                var EmployeeFromDb = await _db.Employee.FindAsync(Employee.Id);
                EmployeeFromDb.Age = Employee.Age;
                EmployeeFromDb.Attrition = Employee.Attrition;
                EmployeeFromDb.BusinessTravel = Employee.BusinessTravel;
                EmployeeFromDb.DailyRate = Employee.DailyRate;
                EmployeeFromDb.Department = Employee.Department;
                EmployeeFromDb.DistanceFromHome = Employee.DistanceFromHome;
                EmployeeFromDb.Education = Employee.Education;
                EmployeeFromDb.EducationField = Employee.EducationField;
                EmployeeFromDb.EmployeeCount = Employee.EmployeeCount;
                EmployeeFromDb.EmployeeNumber = Employee.EmployeeNumber;
                EmployeeFromDb.EnvironmentSatisfaction = Employee.EnvironmentSatisfaction;
                EmployeeFromDb.Gender = Employee.Gender;
                EmployeeFromDb.HourlyRate = Employee.HourlyRate;
                EmployeeFromDb.JobInvolvement = Employee.JobInvolvement;
                EmployeeFromDb.JobLevel = Employee.JobLevel;
                EmployeeFromDb.JobRole = Employee.JobRole;
                EmployeeFromDb.JobSatisfaction = Employee.JobSatisfaction;
                EmployeeFromDb.MaritalStatus = Employee.MaritalStatus;
                EmployeeFromDb.MonthlyIncome = Employee.MonthlyIncome;
                EmployeeFromDb.MonthlyRate = Employee.MonthlyRate;
                EmployeeFromDb.NumCompaniesWorked = Employee.NumCompaniesWorked;
                EmployeeFromDb.Over18 = Employee.Over18;
                EmployeeFromDb.OverTime = Employee.OverTime;
                EmployeeFromDb.PercentSalaryHike = Employee.PercentSalaryHike;
                EmployeeFromDb.PerformanceRating = Employee.PerformanceRating;
                EmployeeFromDb.RelationshipSatisfaction = Employee.RelationshipSatisfaction;
                EmployeeFromDb.StandardHours = Employee.StandardHours;
                EmployeeFromDb.StockOptionLevel = Employee.StockOptionLevel;
                EmployeeFromDb.TotalWorkingYears = Employee.TotalWorkingYears;
                EmployeeFromDb.TrainingTimesLastYear = Employee.TrainingTimesLastYear;
                EmployeeFromDb.WorkLifeBalance = Employee.WorkLifeBalance;
                EmployeeFromDb.YearsAtCompany = Employee.YearsAtCompany;
                EmployeeFromDb.YearsInCurrentRole = Employee.YearsInCurrentRole;
                EmployeeFromDb.YearsSinceLastPromotion = Employee.YearsSinceLastPromotion;
                EmployeeFromDb.YearsWithCurrManager = Employee.YearsWithCurrManager;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
