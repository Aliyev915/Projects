using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public DashboardController(AppDbContext db, UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
            _db = db;
        }
        
        public IActionResult Index()
        {
            ViewBag.Users = _usermanager.Users.Count();
            ViewBag.Jobs = _db.Jobs.Count();
            ViewBag.Candidates = _db.Candidates.Count();
            ViewBag.Bookmarks = _db.Bookmarks.Count();
            IEnumerable<AppUser> model = _usermanager.Users;
            return View(model);
        }
    }
}