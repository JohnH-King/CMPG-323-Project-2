using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;
using Project_2__26047179.Data.Repository.IRepository;
using Project_2__26047179.Models;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class DTController : Controller
    {
        [TempData]
        public string Message { get; set; }

        private readonly IUnitOfWork _unitOfWork;


        public DTController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Upsert(int? id)
        {
            Employee employee = new Employee();
            if(id==null)
            {
                return View(employee);
            }
            employee = _unitOfWork.Employee.Get(id.GetValueOrDefault());
            if(employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Employee.GetAll() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var employeeFromDb = _unitOfWork.Employee.Get(id);
            if (employeeFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }
            _unitOfWork.Employee.Remove(employeeFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful." });
        }
    }
}
