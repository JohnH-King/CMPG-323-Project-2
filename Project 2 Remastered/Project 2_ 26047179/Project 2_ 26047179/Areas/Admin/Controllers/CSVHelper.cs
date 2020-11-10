using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;
using Project_2__26047179.Models;
using Project_2__26047179.Models.ViewModels;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CSVHelper : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly List<Employee> employees = new List<Employee>
                {
                    new Employee{EmployeeNumber=1, Department="test", EmployeeCount=1, EnvironmentSatisfaction=1, OverTime="Yes", PerformanceRating=5, StockOptionLevel=0},
                    new Employee{EmployeeNumber=2, Department="test", EmployeeCount=0, EnvironmentSatisfaction=1, OverTime="Yes", PerformanceRating=5, StockOptionLevel=2},
                    new Employee{EmployeeNumber=3, Department="test", EmployeeCount=2, EnvironmentSatisfaction=1, OverTime="Yes", PerformanceRating=5, StockOptionLevel=3},
                    new Employee{EmployeeNumber = 4, Department = "test", EmployeeCount = 3, EnvironmentSatisfaction = 1, OverTime = "No", PerformanceRating = 5, StockOptionLevel = 0 },
                };


        [TempData]
        public string StatusMessage { get; set; }

        public CSVHelper(ApplicationDbContext db)
        {
            _db = db;
        }



        // GET: CSVHelper



        //CSV FUNCTIONALITY
        //export as CSV

        public Employee Employee { get; set; }

        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            return Json(new { data = await _db.Employee.ToListAsync() });
        }
        /*[HttpGet]
        public async Task<IActionResult> GetJobInfo()
        {
            return Json(new { data = await _db.JobInfo.ToListAsync() });
        }
        [HttpGet]
        public async Task<IActionResult> GetJobSpecs()
        {
            return Json(new { data = await _db.JobSpecs.ToListAsync() });
        }
        [HttpGet]
        public async Task<IActionResult> GetPersonal()
        {
            return Json(new { data = await _db.Personal.ToListAsync() });
        }*/


        public IActionResult WriteCSV()
        {

            var builder = new StringBuilder();
            builder.AppendLine("Age, Attrition, BusinessTravel,DailyRate, Department, DistanceFromHome, Education, EducationField, EmployeeCount, EmployeeNumber, EnvironmentSatisfaction,Gender, HourlyRate, JobInvolvement,JobLevel, JobRole, JobSatisfaction,MaritalStatus, MonthlyIncome, MonthlyRate, NumCompaniesWorked, Over18, OverTime, PercentSalaryHike, PerformanceRating, RelationshipSatisfaction, StandardHours, StockOptionLevel, TotalWorkingYears, TrainingTimesLastYear, WorkLifeBalance, YearsAtCompany, YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager");
            foreach (var emp in employees)
            {
                builder.AppendLine($"{emp.EmployeeNumber},{emp.Department},{emp.EmployeeCount},{emp.EnvironmentSatisfaction},{emp.OverTime},{emp.PerformanceRating},{emp.StockOptionLevel}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "EmployeeInfo.CSV");
        }

        //import a CSV file
        public string ReadCSV()
        {
            string msg = "";

            using (StreamReader sr = new StreamReader("C:\\Coding\\CMPG 323\\CMPG323 project 2 dataset.csv"))
            {
                //Validate format of CSV
                string[] arr = new string[]{"Age", "Attrition", "BusinessTravel", "DailyRate", "Department", "DistanceFromHome", "Education", "EducationField", "EmployeeCount", "EmployeeNumber", "EnvironmentSatisfaction","Gender"
                    , "HourlyRate", "JobInvolvement","JobLevel", "JobRole", "JobSatisfaction","MaritalStatus","MonthlyIncome","MonthlyRate","NumCompaniesWorked","Over18","OverTime", "PercentSalaryHike","PerformanceRating",
                    "RelationshipSatisfaction", "StandardHours", "StockOptionLevel", "TotalWorkingYears", "TrainingTimesLastYear", "WorkLifeBalance", "YearsAtCompany" , "YearsInCurrentRole", "YearsSinceLastPromotion", "YearsWithCurrManager" };
                String hTemp = ""; //header temp


                String name = "";
                String sAge = "";
                String sAttrition = "";
                int x = 0;
                // String nameValue = "";
                while (!sr.EndOfStream)
                {
                    x++;
                    string[] col = sr.ReadLine().Split(',');

                    sAge = col[0];
                    sAttrition = col[1];

                    if (x == 1)
                    {
                        Console.WriteLine("Headers: " + x + ": ");
                        for (int i = 0; i < col.Length; i++)
                        {
                            name = col[i];
                            if (col[i].Contains(arr[i]))
                            {
                                msg += (name + ", ");
                                Console.Write(name + ", ");
                            }
                            else
                            {
                                Console.WriteLine("--Incorrect Field Type--");

                                //changes arr to adjust to difference in indexes, indexes only!
                                arr[i] = col[i];

                                msg += (name + ", ");
                                Console.WriteLine(name + ", ");
                            }

                        }
                        Console.WriteLine(name + " ");

                        //jason object
                    }
                    else
                    {
                        msg += (x + ": ");
                        Console.WriteLine(x + ": ");
                        for (int i = 0; i < col.Length; i++)
                        {
                            hTemp = col[i];
                            Console.Write(hTemp + ", ");
                        }
                        Console.WriteLine(": " + hTemp);
                    }
                }
            }
            return msg;
            //return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "EmployeeInfo.CSV");
        }
        public IActionResult Index()
        {

            //var jobInfo = await _db.JobInfo.Include(s => s.Employee).ToListAsync();
            //return View(jobInfo);
            /*
            Employee employees = new Employee();
            List<CSVViewModel> CSVList = new List<CSVViewModel>();
            var clist = (from employeses in _db.Employee
                         join jobInfos in _db.Employee on employees.Id equals Id
                         select new { employeses.EmployeeNumber, employeses.EmployeeCount, employeses.Department, jobInfos.Education, jobInfos.NumCompaniesWorked }).ToList();
            if (clist != null)
            {
                foreach (var item in CSVList)
                {
                    CSVViewModel objcvm = new CSVViewModel(); // ViewModel

                    objcvm.EmployeeNumber = item.EmployeeNumber;

                    objcvm.EmployeeCount = item.EmployeeCount;

                    objcvm.Department = item.Department;

                    objcvm.Education = item.Education;

                    objcvm.NumCompaniesWorked = item.NumCompaniesWorked;

                    CSVList.Add(objcvm);
                }
                return View(CSVList);
            }
            else { */
                return View(); 
            //}
        }

        public IActionResult Excel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Employees");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Age, Attrition, BusinessTravel,DailyRate, Department, DistanceFromHome, Education, EducationField, EmployeeCount, EmployeeNumber, EnvironmentSatisfaction,Gender, HourlyRate, JobInvolvement,JobLevel, JobRole, JobSatisfaction,MaritalStatus, MonthlyIncome, MonthlyRate, NumCompaniesWorked, Over18, OverTime, PercentSalaryHike, PerformanceRating, RelationshipSatisfaction, StandardHours, StockOptionLevel, TotalWorkingYears, TrainingTimesLastYear, WorkLifeBalance, YearsAtCompany, YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager";

                foreach (var emp in employees)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = emp.EmployeeNumber + "," + emp.Department + "," + emp.EmployeeCount + "," + emp.EnvironmentSatisfaction + "," + emp.OverTime + "," + emp.PerformanceRating + "," + emp.StockOptionLevel;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "EmployeeInfo.xlsx"
                        );
                }
            }
        }



        //===================================================================================




        //==========================================================================
    }
}
