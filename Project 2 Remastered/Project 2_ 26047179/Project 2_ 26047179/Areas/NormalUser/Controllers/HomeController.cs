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
using Microsoft.AspNetCore.Authorization;
using Project_2__26047179.Utility;

namespace Project_2__26047179.Controllers
{
    [Authorize(Roles = SD.NormalUser + "," + SD.ManagerUser)]
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
            List<int> repartitionsr = new List<int>();
            List<int> repartitionsg = new List<int>();
            List<int> repartitionsgm = new List<int>();
            List<int> repartitionsgf = new List<int>();

            var repgm = repartitionsgm;
            var repgf = repartitionsgf;
            var rep = repartitions;
            var repc = repartitionsc;
            var repd = repartitionsd;
            var repr = repartitionsr;

            var ages = list.Select(x => x.Age).Distinct();
            var empCount = list.Select(x => x.EmployeeCount).Distinct();
            var roles = list.Select(x => x.JobRole).Distinct();
            var department = list.Select(x => x.Department).Distinct();
            var gender = list.Select(x => x.Gender).Distinct();


            

            foreach (var item in ages)
            {
                repartitions.Add(list.Count((x => x.Age == item)));
            }            

            
            foreach (var itemd in department)
            {
                repartitionsd.Add(list.Count((x => x.Department == itemd)));
            }

            foreach (var itemr in roles)
            {
                repartitionsr.Add(list.Count((x => x.JobRole == itemr)));
                foreach (var itemg in gender)
                {
                    if (itemg == "male") repartitionsgm.Add(list.Count((x => x.JobRole == itemr)));
                    if (itemg == "female") repartitionsgf.Add(list.Count((x => x.JobRole == itemr)));
                }
            }

            foreach (var items in empCount)
            {
                repartitionsc.Add(list.Count((x => x.EmployeeCount == items)));
            }

            ViewBag.DEP = department;
            ViewBag.AGES = ages;
            ViewBag.EMPCOUNT = empCount;
            ViewBag.ROLES = roles;
            ViewBag.GENDER = gender;
            ViewBag.REPG = repartitionsg.ToList();
            ViewBag.REPR = repartitionsr.ToList();
            ViewBag.REP = repartitions.ToList();
            ViewBag.REPC = repartitionsc.ToList();
            ViewBag.REPD = repartitionsd.ToList();
            ViewBag.REPGM = repartitionsgm.ToList();
            ViewBag.REPGF = repartitionsgf.ToList();
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
