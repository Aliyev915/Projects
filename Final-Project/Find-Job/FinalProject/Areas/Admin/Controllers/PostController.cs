using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Moderator")]
    public class PostController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public PostController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Locations = _db.Locations.OrderBy(l=>l.Name);
            ViewBag.Currencies = _db.Currencies.OrderBy(c=>c.Name);
            ViewBag.Types = _db.Types;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PostVM post)
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Locations = _db.Locations;
            ViewBag.Currencies = _db.Currencies;
            ViewBag.Types = _db.Types;
            if (!ModelState.IsValid)
            {
                return View();
            }
            Category category = await _db.Categories.FirstOrDefaultAsync(c => c.Name == post.Category);
            Location location = await _db.Locations.FirstOrDefaultAsync(l => l.Name == post.City);
            Currency currency = await _db.Currencies.FirstOrDefaultAsync(c => c.Name == post.Currency);
            Models.Type type = await _db.Types.FirstOrDefaultAsync(t => t.Name == post.Type);
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            CompanyModerator moderator = await _db.Moderators.Include(c=>c.Company).FirstOrDefaultAsync(c=>c.AppUserId==user.Id);
            Demand demand = new Demand
            {
                Education=post.Demand
            };
            await _db.Demands.AddAsync(demand);
            #region AddJob
            Job newJob = new Job
            {
                Name = post.Title,
                AppUserId=user.Id,
                Description = post.Description,
                Deadline = post.Deadline,
                CompanyId=moderator.Company.Id,
                CategoryId=category.Id,
                DemandId=demand.Id,
                LocationId=location.Id,
                Salary=int.Parse(post.Salary.ToString()),
                TypeId=type.Id,
                CurrencyId=currency.Id,
                Experience = $"{post.MinExperience} - {post.MaxExperience}"
            };
            #endregion
            await _db.Jobs.AddAsync(newJob);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index","Job");
        }
    }
}