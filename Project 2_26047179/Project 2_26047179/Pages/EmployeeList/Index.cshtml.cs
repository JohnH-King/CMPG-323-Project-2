using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_2_26047179.Model;

namespace Project_2_26047179.Pages.EmployeeList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Employee> Employees { get; set; }

        public async Task OnGet()    // await uses async. This is Get Handler
        {
            Employees = await _db.Employee.ToListAsync(); //Assign the employee that we found
        }

        public async Task<IActionResult> OnPostDelete(int id)//handler name is delete
        {
            var employee = await _db.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            _db.Employee.Remove(employee);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
