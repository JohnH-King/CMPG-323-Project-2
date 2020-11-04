using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;

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
    }
}
