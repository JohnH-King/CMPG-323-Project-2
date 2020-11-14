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


        public IActionResult Index()
        {
            var list = _db.Employee.ToList();
            List<int> repartitions = new List<int>();
            List<int> repartitionsc = new List<int>();
            var ages = list.Select(x => x.Age).Distinct();
            var empCount = list.Select(s => s.EmployeeCount).Distinct();
            foreach (var item in ages)
            {
                repartitions.Add(list.Count((x => x.Age == item)));
            }
            foreach (var item in empCount)
            {
                repartitionsc.Add(list.Count((x => x.EmployeeCount == item)));
            }
            var rep = repartitions;
            ViewBag.AGES = ages;
            ViewBag.EMPCOUNT = empCount;
            ViewBag.REP = repartitions.ToList();
            ViewBag.REPC = repartitionsc.ToList();
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
