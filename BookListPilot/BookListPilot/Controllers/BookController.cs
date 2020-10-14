using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListPilot.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookListPilot.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult GetAll()
        {
            return Json(new { data = _db.Book.ToList() });
        }
    }
}
