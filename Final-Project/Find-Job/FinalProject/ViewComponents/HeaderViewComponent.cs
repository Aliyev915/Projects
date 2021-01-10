using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FinalProject.DAL;
using FinalProject.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public HeaderViewComponent(AppDbContext db, UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser currentUser = await _usermanager.FindByNameAsync(User.Identity.Name);
                ViewBag.Role = (await _usermanager.GetRolesAsync(currentUser))[0];
            }
            Bio model = _db.Bio.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
