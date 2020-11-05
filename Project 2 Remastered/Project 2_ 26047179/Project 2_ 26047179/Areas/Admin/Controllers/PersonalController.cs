using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;
using Project_2__26047179.Models;
using Project_2__26047179.Models.ViewModels;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PersonalController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public PersonalController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET Index
        public async Task<IActionResult> Index()
        {
            var personal = await _db.Personal.Include(s => s.Employee).ToListAsync();
            return View(personal);
        }

        //Get - Create
        public async Task<IActionResult> Create()
        {
            PersonalAndEmployeeViewModel model = new PersonalAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                Personal = new Models.Personal(),
                PersonalList = await _db.Personal.OrderBy(p => p.Age).Select(p => p.Age).Distinct().ToListAsync()
            };
            return View(model);
        }

        //Post - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonalAndEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesPersonalExist = _db.Personal.Include(s => s.Employee).Where(s => s.Age == model.Personal.Age && s.Employee.Id == model.Personal.EmployeeId);

                if (doesPersonalExist.Count() > 0)
                {
                    StatusMessage = "Error : Job Role exists under " + doesPersonalExist.First().Employee.EmployeeNumber + " employee number. Please use another Number";
                }
                else
                {
                    _db.Personal.Add(model.Personal);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            PersonalAndEmployeeViewModel modelVM = new PersonalAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                Personal = model.Personal,
                PersonalList = await _db.Personal.OrderBy(p => p.Age).Select(p => p.Age).ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }
    }
}
