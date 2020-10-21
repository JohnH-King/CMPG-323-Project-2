using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_2_26047179.Model;
using System.IO;
using System.Text;
using ClosedXML;
using Microsoft.EntityFrameworkCore;

namespace Project_2_26047179.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public Employee Employee { get; set; }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Employee.ToListAsync() });
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
            return Json(new { success = true, message = "Deleta successful" });
        }
        


    }
}
