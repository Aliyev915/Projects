using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.DAL;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Areas.Admin.ViewComponents
{
    public class SideBarViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public SideBarViewComponent(AppDbContext db, UserManager<AppUser> usermanager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _usermanager = usermanager;
            _roleManager = roleManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser model = await _usermanager.FindByNameAsync(User.Identity.Name);
            return View(await Task.FromResult(model));
        }
    }
}
