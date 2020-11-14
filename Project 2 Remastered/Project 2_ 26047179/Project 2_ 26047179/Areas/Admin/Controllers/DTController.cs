﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("api/Employee")]
    [ApiController]
    public class DTController : Controller
    {
        [TempData]
        public string Message { get; set; }

        private readonly ApplicationDbContext _db;

        public DTController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Employee.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var empFromDb = await _db.Employee.FirstOrDefaultAsync(u => u.Id == id);
            if (empFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _db.Employee.Remove(empFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
    }
}