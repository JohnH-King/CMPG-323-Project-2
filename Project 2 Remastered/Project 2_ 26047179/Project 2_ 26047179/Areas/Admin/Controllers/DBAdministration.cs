using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;
using Project_2__26047179.Models;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DBAdministration : Controller
    {

        private readonly ApplicationDbContext _db;

        public DBAdministration(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Employee.ToListAsync() });
        }

        public async Task<IActionResult> Index()
        {//use dependency injection
            return View(await _db.Employee.ToListAsync());
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employeeFromDb = _db.Employee.FirstOrDefaultAsync(u => u.Id == id);
            if (employeeFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            //_db.Employee.Remove(employeeFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }


        //Get - Create
        public IActionResult Create()
        {
            return View();
        }

        //Post - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)//valid on server side, like if num is empty
            {
                _db.Add(employee);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));//or "Index" avoids spelling mistakes
            }
            return View(employee);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _db.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Update(employee);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)//nullable field
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _db.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _db.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}
