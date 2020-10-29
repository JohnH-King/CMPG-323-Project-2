using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;
using Project_2__26047179.Models;
using Project_2__26047179.Models.ViewModels;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobSpecsController : Controller
    {        
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public JobSpecsController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET - index
        public async Task<IActionResult> Index()
        {
            var jobSpecs = await _db.JobSpecs.Include(s=>s.Employee).ToListAsync();
            return View(jobSpecs);
        }

        //Get - Create
        public async Task<IActionResult> Create()
        {
            JobSpecAndEmployeeViewModel model = new JobSpecAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                JobSpecs = new Models.JobSpecs(),
                JobSpecsList = await _db.JobSpecs.OrderBy(p => p.JobRole).Select(p => p.JobRole).Distinct().ToListAsync()
            };

            return View(model);
        }

        //Post - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobSpecAndEmployeeViewModel model)
        {
            if(ModelState.IsValid)
            {
                var doesJobSpecExist = _db.JobSpecs.Include(s => s.Employee).Where(s => s.JobRole == model.JobSpecs.JobRole && s.Employee.Id==model.JobSpecs.EmployeeId);

                if(doesJobSpecExist.Count()>0)
                {
                    StatusMessage = "Error : Job Role exists under " + doesJobSpecExist.First().Employee.EmployeeNumber + " employee number. Please use another Number";
                }
                else 
                {
                    _db.JobSpecs.Add(model.JobSpecs);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            JobSpecAndEmployeeViewModel modelVM = new JobSpecAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                JobSpecs = model.JobSpecs,
                JobSpecsList = await _db.JobSpecs.OrderBy(p => p.JobRole).Select(p => p.JobRole).ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }


        [ActionName("GetJobSpecs")]
        public async Task<IActionResult> GetJobSpecs(int id)
        {
            List<JobSpecs> jobSpecs = new List<JobSpecs>();

            jobSpecs = await (from jobSpec in _db.JobSpecs
                        where jobSpec.EmployeeId == id
                        select jobSpec).ToListAsync();
            return Json(new SelectList(jobSpecs, "Id", "JobRole"));
        }


        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }
            var jobSpecs = await _db.JobSpecs.SingleOrDefaultAsync(m => m.Id == id);
            if (jobSpecs == null) { return NotFound(); }

            JobSpecAndEmployeeViewModel model = new JobSpecAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                JobSpecs = jobSpecs,
                JobSpecsList = await _db.JobSpecs.OrderBy(p => p.JobRole).Select(p => p.JobRole).Distinct().ToListAsync()
            };

            return View(model);
        }
        
        //Post - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, JobSpecAndEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesJobSpecExist = _db.JobSpecs.Include(s => s.Employee).Where(s => s.JobRole == model.JobSpecs.JobRole && s.Employee.Id == model.JobSpecs.EmployeeId);

                if (doesJobSpecExist.Count() > 0)
                {
                    StatusMessage = "Error : Job Role exists under " + doesJobSpecExist.First().Employee.EmployeeNumber + " employee number. Please use another Number";
                }
                else
                {
                    var jobSpecFromDb = await _db.JobSpecs.FindAsync(id);
                     jobSpecFromDb.JobRole = model.JobSpecs.JobRole;    //update Role

                    
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            JobSpecAndEmployeeViewModel modelVM = new JobSpecAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                JobSpecs = model.JobSpecs,
                JobSpecsList = await _db.JobSpecs.OrderBy(p => p.JobRole).Select(p => p.JobRole).ToListAsync(),
                StatusMessage = StatusMessage
            };
            modelVM.JobSpecs.Id = id;    //error handling
            return View(modelVM);
        }


    }
}
