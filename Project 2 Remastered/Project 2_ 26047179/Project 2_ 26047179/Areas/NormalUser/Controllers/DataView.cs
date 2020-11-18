using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;
using Project_2__26047179.Models;
using Project_2__26047179.Utility;
using Microsoft.AspNetCore.Authorization;
using Project_2__26047179.Data.Repository.IRepository;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.NormalUser)]
    [Area("NormalUser")]
    public class DataView : Controller
    {

        private readonly IUnitOfWork _unitOfWork;


        public DataView(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IActionResult> Index()
        {//use dependency injection
            return View(_unitOfWork.Employee.GetAll());
        }


        public IActionResult Upsert(int? id)
        {
            Employee employee = new Employee();
            if (id == null)
            {
                return View(employee);
            }
            employee = _unitOfWork.Employee.Get(id.GetValueOrDefault());
            if (employee == null)
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
