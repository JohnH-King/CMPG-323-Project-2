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

        [ActionName("GetPersonal")]
        public async Task<IActionResult> GetPersonal(int id)
        {
            List<Personal> personals = new List<Personal>();

            personals = await (from personal in _db.Personal
                              where personal.EmployeeId == id
                              select personal).ToListAsync();
            return Json(new SelectList(personals, "Id", "Age"));
        }


        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }
            var personals = await _db.Personal.SingleOrDefaultAsync(m => m.Id == id);
            if (personals == null) { return NotFound(); }

            PersonalAndEmployeeViewModel model = new PersonalAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                Personal = personals,
                PersonalList = await _db.Personal.OrderBy(p => p.Age).Select(p => p.Age).Distinct().ToListAsync()
            };

            return View(model);
        }

        //Post - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PersonalAndEmployeeViewModel model)
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
                    var personalsFromDb = await _db.Personal.FindAsync(id);
                    personalsFromDb.Age = model.Personal.Age;    //update Role


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
            modelVM.Personal.Id = id;    //error handling
            return View(modelVM);
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var personals = await _db.Personal.Include(s => s.Employee).SingleOrDefaultAsync(m => m.Id == id);
            if (personals == null)
            {
                return NotFound();
            }
            return View(personals);
        }

        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)//nullable field
        {
            if (id == null)
            {
                return NotFound();
            }
            var personals = await _db.Personal.Include(s => s.Employee).SingleOrDefaultAsync(m => m.Id == id);
            if (personals == null)
            {
                return NotFound();
            }
            return View(personals);
        }

        //POST - DELETE
        [HttpPost, ActionName("Delete")]    //is a delete action method
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) //id = @model, Has to have a value != null
        {
            var personals = await _db.Personal.Include(s => s.Employee).SingleOrDefaultAsync(m => m.Id == id);
            if (personals == null)
            {
                return NotFound();  //or to the View
            }
            _db.Personal.Remove(personals);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
