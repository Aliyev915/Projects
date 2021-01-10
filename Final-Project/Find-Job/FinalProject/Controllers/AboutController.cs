using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public AboutController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public IActionResult Index()
        {
            ViewBag.UserCount = _usermanager.Users.Count();
            ViewBag.JobCount = _db.Jobs.Count();
            ViewBag.ResumeCount = _db.Candidates.Count();
            ViewBag.CompanyCount = _db.Companies.Count();
            AboutVM model = new AboutVM
            {
                Statistics = _db.Statistics,
                Services = _db.Services,
                Sliders = _db.Sliders,
                Categories = _db.Categories.Include(c => c.Jobs),
                Companies = _db.Companies
            };
            return View(model);
        }
    }
}