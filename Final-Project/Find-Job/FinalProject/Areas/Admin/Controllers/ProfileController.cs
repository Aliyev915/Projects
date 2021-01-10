using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Extensions;
using FinalProject.Helpers;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly IHostingEnvironment _env;
        public ProfileController(UserManager<AppUser> usermanager,RoleManager<IdentityRole> rolemanager,IHostingEnvironment env)
        {
            _usermanager = usermanager;
            _rolemanager = rolemanager;
            _env = env;
        }
        public async Task<IActionResult> Edit(string username)
        {
            AppUser currentUser = await _usermanager.FindByNameAsync(username);
            return View(currentUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string username,AppUser user)
        {
            AppUser currentUser = await _usermanager.FindByNameAsync(username);
            currentUser.Fullname = user.Fullname;
            currentUser.Adress = user.Adress;
            currentUser.PhoneNumber = user.PhoneNumber;
            if (user.Photo != null)
            {
                if (currentUser.Image != null)
                {
                    Helper.DeleteImage(currentUser.Image);
                }
                currentUser.Image = await user.Photo.CopyImage(_env.WebRootPath, @"img\");
            }
            await _usermanager.UpdateAsync(currentUser);
            return View(currentUser);
        }

    }
}