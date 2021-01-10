using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Helpers;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _db;
        public UserController(UserManager<AppUser> usermanager, AppDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _usermanager = usermanager;
            _db = db;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            IEnumerable<AppUser> users = _usermanager.Users;
            ViewBag.manager = _usermanager;
            return View(users);
        }
        public async Task<IActionResult> Edit(string username)
        {
            AppUser user = await _usermanager.FindByNameAsync(username);
            if (user == null) return NotFound();
            ViewBag.Roles = Enum.GetValues(typeof(Helper.Roles));
            ViewBag.Companies = _db.Companies;
            UserVM model = new UserVM
            {
                Fullname=user.Fullname,
                Email=user.Email,
                Username=user.UserName,
                Role=(await _usermanager.GetRolesAsync(user))[0]
            };
            if ((await _usermanager.GetRolesAsync(user))[0] == "Moderator")
            {
                CompanyModerator moderator = _db.Moderators.Include(c=>c.Company).Include(c => c.AppUser).
                                    FirstOrDefault(c => c.AppUserId == user.Id);
                model.Company = moderator.Company.Name;
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string username,UserVM userVM)
        {
            AppUser user = await _usermanager.FindByNameAsync(username);
            ViewBag.Roles = Enum.GetValues(typeof(Helper.Roles));
            if (userVM.Role == "Moderator")
            {
                CompanyModerator moderator = new CompanyModerator();
                Company company = _db.Companies.FirstOrDefault(c=>c.Name==userVM.Company);
                moderator.AppUserId = user.Id;
                moderator.CompanyId = company.Id;
                await _db.Moderators.AddAsync(moderator);
            }
            if (user == null) return NotFound();
            string role = (await _usermanager.GetRolesAsync(user))[0];
            await _usermanager.RemoveFromRoleAsync(user, role);
            await _usermanager.AddToRoleAsync(user, userVM.Role);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string username)
        {
            AppUser user = await _usermanager.FindByNameAsync(username);
            if (user == null) return NotFound();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(string username)
        {
            AppUser user = await _usermanager.FindByNameAsync(username);
            if (user == null) return NotFound();
            if (user.IsDeleted == false)
            {
                user.IsDeleted = true;
            }
            else
            {
                user.IsDeleted = false;
            }
            await _usermanager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }
    }
}