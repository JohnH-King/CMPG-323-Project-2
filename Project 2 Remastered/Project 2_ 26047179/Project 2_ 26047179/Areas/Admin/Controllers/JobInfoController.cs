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
    [Area("admin")]
    public class JobInfoController : Controller
    {

        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public JobInfoController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET Index
        public async Task<IActionResult> Index()
        {
            var jobInfo = await _db.JobInfo.Include(s=>s.Employee).ToListAsync();
            return View(jobInfo);
        }

        //GET - Create
        public async Task<IActionResult> Create()
        {
            JobInfoAndEmployeeViewModel model = new JobInfoAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                JobInfo = new Models.JobInfo(),
                JobInfoList = await _db.JobInfo.OrderBy(p => p.EducationField).Select(p => p.EducationField).Distinct().ToListAsync()
            };

            return View(model);
        }

        //Post - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobInfoAndEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesJobSpecExist = _db.JobInfo.Include(s => s.Employee).Where(s => s.EducationField == model.JobInfo.EducationField && s.Employee.Id == model.JobInfo.EmployeeId);

                if (doesJobSpecExist.Count() > 0)
                {
                    StatusMessage = "Error : Education Field exists under " + doesJobSpecExist.First().Employee.EmployeeNumber + " employee number. Please use another Number";
                }
                else
                {
                    _db.JobInfo.Add(model.JobInfo);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            JobInfoAndEmployeeViewModel modelVM = new JobInfoAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                JobInfo = model.JobInfo,
                JobInfoList = await _db.JobInfo.OrderBy(p => p.EducationField).Select(p => p.EducationField).ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }


        [ActionName("GetJobInfo")]
        public async Task<IActionResult> GetJobInfo(int id)
        {
            List<JobInfo> jobInfo = new List<JobInfo>();

            jobInfo = await (from jobSpec in _db.JobInfo
                              where jobSpec.EmployeeId == id
                              select jobSpec).ToListAsync();
            return Json(new SelectList(jobInfo, "Id", "EducationField"));
        }
    }
}
