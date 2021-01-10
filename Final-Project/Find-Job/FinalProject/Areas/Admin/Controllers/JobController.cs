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
    public class JobController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public JobController(AppDbContext db, UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        [Authorize(Roles ="Admin, Moderator")]
        public async Task<IActionResult> Index()
        {
            AppUser currentUser = await _usermanager.FindByNameAsync(User.Identity.Name);
            IEnumerable<Job> model = _db.Jobs.Include(j => j.Location).Include(j => j.Type).Include(j => j.Category)
                                            .Where(j=>j.AppUserId==currentUser.Id);
            return View(model);
        }

        #region Edit Posted Jobs
        public async Task<IActionResult> Edit(int? Id)
        {
            ViewBag.Locations = _db.Locations;
            ViewBag.Types = _db.Types;
            ViewBag.Categories = _db.Categories;
            ViewBag.Currencies = _db.Currencies;
            if (Id == null) return NotFound();
            Job job = await _db.Jobs.Include(j => j.Category).Include(j => j.Demand).Include(j => j.Type).
                            Include(j => j.Location).FirstOrDefaultAsync(j => j.Id == Id);
            if (job == null) return NotFound();
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Job job, int? Id)
        {
            if (Id == null) return NotFound();
            Job editedJob = await _db.Jobs.Include(j => j.Category).Include(j => j.Demand).Include(j => j.Type).
                            Include(j => j.Location).FirstOrDefaultAsync(j => j.Id == Id);
            if (editedJob == null) return NotFound();
            Category category = await _db.Categories.FirstOrDefaultAsync(c => c.Name == job.Category.Name);
            Location location = await _db.Locations.FirstOrDefaultAsync(l => l.Name == job.Location.Name);
            Models.Type type = await _db.Types.FirstOrDefaultAsync(t => t.Name == job.Type.Name);
            editedJob.Name = job.Name;
            editedJob.Description = job.Description;
            editedJob.Experience = job.Experience;
            editedJob.Salary = job.Salary;
            editedJob.Category = category;
            editedJob.Location = location;
            editedJob.Type = type;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region Delete Posted Jobs
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Job job = await _db.Jobs.Include(j => j.Category).Include(j => j.Demand).Include(j => j.Type).
                            Include(j => j.Location).FirstOrDefaultAsync(j => j.Id == Id);
            if (job == null) return NotFound();
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Job job = await _db.Jobs.Include(j => j.Category).Include(j => j.Demand).Include(j => j.Type).
                            Include(j => j.Location).FirstOrDefaultAsync(j => j.Id == Id);
            if (job == null) return NotFound();
            _db.Jobs.Remove(job);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}