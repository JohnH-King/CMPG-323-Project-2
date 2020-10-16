using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project_2_26047179.Model;

namespace Project_2_26047179.Pages.EmployeeList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public void OnGet()
        {
           
        }

        public async Task<IActionResult> OnPost()//handler name is delete
        {
            if (ModelState.IsValid)
            {
                await _db.Employee.AddAsync(Employee);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }            
        }
    }
}
