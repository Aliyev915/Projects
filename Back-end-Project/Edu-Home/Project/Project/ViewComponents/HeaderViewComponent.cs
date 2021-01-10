using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HeaderViewComponent(AppDbContext db, UserManager<AppUser> usermanager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _usermanager = usermanager;
            _roleManager = roleManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = user.Fullname;
                ViewBag.Role = (await _usermanager.GetRolesAsync(user))[0];
                if (ViewBag.Role == "Moderator")
                {
                    ViewBag.Course = _db.Courses.Include(c => c.Category).Include(c => c.CourseFeatures).FirstOrDefault(c => c.AppUserId == user.Id);
                }
            }
            Bio model = _db.Bio.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
