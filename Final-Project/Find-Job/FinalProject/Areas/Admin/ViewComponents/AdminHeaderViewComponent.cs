using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.Admin.ViewComponents
{
    public class AdminHeaderViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public AdminHeaderViewComponent(AppDbContext db, UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser model = await _usermanager.FindByNameAsync(User.Identity.Name);
            return View(await Task.FromResult(model));
        }
    }
}
