using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListPilot.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListPilot.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()    // await uses async. This is Get Handler
        {
            Books = await _db.Book.ToListAsync(); //Assign the books that we found
        }

        public async Task<IActionResult> OnPostDelete(int id)//handler name is delete
        {
            var book = await _db.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.Book.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
