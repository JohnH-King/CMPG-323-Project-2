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
                var doesJobInfoExist = _db.JobInfo.Include(s => s.Employee).Where(s => s.EducationField == model.JobInfo.EducationField && s.Employee.Id == model.JobInfo.EmployeeId);

                if (doesJobInfoExist.Count() > 0)
                {
                    StatusMessage = "Error : Education Field exists under " + doesJobInfoExist.First().Employee.EmployeeNumber + " employee number. Please use another Number";
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
            List<JobInfo> jobInfos = new List<JobInfo>();

            jobInfos = await (from jobInfo in _db.JobInfo
                              where jobInfo.EmployeeId == id
                              select jobInfo).ToListAsync();
            return Json(new SelectList(jobInfos, "Id", "EducationField"));
        }


        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }
            var jobInfos= await _db.JobInfo.SingleOrDefaultAsync(m => m.Id == id);
            if (jobInfos == null) { return NotFound(); }

            JobInfoAndEmployeeViewModel model = new JobInfoAndEmployeeViewModel()
            {
                EmployeeList = await _db.Employee.ToListAsync(),
                JobInfo = jobInfos,
                JobInfoList = await _db.JobInfo.OrderBy(p => p.EducationField).Select(p => p.EducationField).Distinct().ToListAsync()
            };

            return View(model);
        }

        //Post - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, JobInfoAndEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesJobInfoExist = _db.JobInfo.Include(s => s.Employee).Where(s => s.EducationField == model.JobInfo.EducationField && s.Employee.Id == model.JobInfo.EmployeeId);

                if (doesJobInfoExist.Count() > 0)
                {
                    StatusMessage = "Error : Job Role exists under " + doesJobInfoExist.First().Employee.EmployeeNumber + " employee number. Please use another Number";
                }
                else
                {
                    var jobInfoFromDb = await _db.JobInfo.FindAsync(id);
                    jobInfoFromDb.EducationField = model.JobInfo.EducationField; 

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
            modelVM.JobInfo.Id = id;    //error handling
            return View(modelVM);
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var jobInfos = await _db.JobInfo.Include(s => s.Employee).SingleOrDefaultAsync(m => m.Id == id);
            if (jobInfos == null)
            {
                return NotFound();
            }
            return View(jobInfos);
        }

        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)//nullable field
        {
            if (id == null)
            {
                return NotFound();
            }
            var jobInfos = await _db.JobInfo.Include(s => s.Employee).SingleOrDefaultAsync(m => m.Id == id);
            if (jobInfos == null)
            {
                return NotFound();
            }
            return View(jobInfos);
        }

        //POST - DELETE
        [HttpPost, ActionName("Delete")]    //is a delete action method
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) //id = @model, Has to have a value != null
        {
            var jobInfos = await _db.JobInfo.Include(s => s.Employee).SingleOrDefaultAsync(m => m.Id == id);
            if (jobInfos == null)
            {
                return NotFound();  //or to the View
            }
            _db.JobInfo.Remove(jobInfos);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
