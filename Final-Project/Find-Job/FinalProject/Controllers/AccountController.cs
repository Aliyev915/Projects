using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Helpers;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager, 
                                 RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user=await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError("","Invalid login Info");
                return View(login);
            }
            var signInResult = await _signInManager.PasswordSignInAsync(user, login.Password,false,true);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Invalid login Info");
                return View(login);
            }
            string role = (await _userManager.GetRolesAsync(user))[0];
            if (role == "Admin")
            {
                return RedirectToAction("Index", "Dashboard",new {area="Admin" });
            }
            return RedirectToAction(nameof(HomeController.Index),"Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = new AppUser
            {
                Fullname=register.Fullname,
                Email=register.Email,
                UserName=register.Username,
                RegisterDate=DateTime.Now,
                Image="user.png"
            };
            var identityResult =await _userManager.CreateAsync(user,register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View();
                }
            }
            await _userManager.AddToRoleAsync(user, Helper.Roles.User.ToString());
            return RedirectToAction(nameof(Login));
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home",new {area="" });
        }

        public async Task CreateRole()
        {
            if ((!await _roleManager.RoleExistsAsync(Helper.Roles.Admin.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Admin.ToString()));
            }

            if ((!await _roleManager.RoleExistsAsync(Helper.Roles.User.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.User.ToString()));
            }
            if ((!await _roleManager.RoleExistsAsync(Helper.Roles.Moderator.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Moderator.ToString()));
            }
        }
    }
}