using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Data;
using Project_2__26047179.Data.Repository.IRepository;
using Project_2__26047179.Utility;

namespace Project_2__26047179.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.ManagerUser)]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitofWork;

        public UserController(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            return View(_unitofWork.User.GetAll(u => u.Id != claim.Value));
        }

        public IActionResult Lock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _unitofWork.User.LockUser(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UnLock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _unitofWork.User.UnlockUser(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
