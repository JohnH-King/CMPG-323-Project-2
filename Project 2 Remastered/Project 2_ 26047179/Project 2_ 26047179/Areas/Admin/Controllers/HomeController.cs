using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Project_2__26047179.Models;
using Project_2__26047179.Data;
using System.Runtime.Serialization;

namespace Project_2__26047179.Controllers
{
    [Area("NormalUser")]
    public class HomeController : Controller
    {


        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = _db.Employee.ToList();
            List<int> repartitions = new List<int>();
            List<int> repartitionsc = new List<int>();
            List<int> repartitionsd = new List<int>();
            var rep = repartitions;
            var repc = repartitionsc;
            var repd = repartitionsd;
            var ages = list.Select(x => x.Age).Distinct();
            var empCount = list.Select(x => x.JobRole).Distinct();

            foreach (var item in ages)
            {
                repartitions.Add(list.Count((x => x.Age == item)));
            }
            var department = list.Select(x => x.Department).Distinct();

            foreach (var itemd in department)
            {
                repartitionsd.Add(list.Count((x => x.JobRole == itemd)));
            }

            foreach (var items in empCount)
            {
                repartitionsc.Add(list.Count((x => x.JobRole == items)));
            }

            ViewBag.DEP = department;
            ViewBag.AGES = ages;
            ViewBag.EMPCOUNT = empCount;
            ViewBag.REP = repartitions.ToList();
            ViewBag.REPC = repartitionsc.ToList();
            ViewBag.REPD = repartitionsd.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public JsonResult EmployeeeData(int id)
        {
            var ages = _db.Employee.Select(x => x.Age).ToList();
            var empCount = _db.Employee.Select(x => x.EmployeeCount).ToList();

            return Json(new { ages, empCount });
        }

    }
}
