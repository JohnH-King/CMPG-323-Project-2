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
    public class EmployeeController : Controller
    {        
        
            private readonly ApplicationDbContext _db;

            public EmployeeController (ApplicationDbContext db)
            {
                _db = db;
            }


        //GET
        public async Task<IActionResult> Index()
        {//use dependency injection
            return View( await _db.Employee.ToListAsync());
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
            if(ModelState.IsValid)//valid on server side, like if num is empty
            {
                _db.Add(employee);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));//or "Index" avoids spelling mistakes
            }
            return View(employee);
        }
    }
}
