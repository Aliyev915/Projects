using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Helpers;
using Project.Models;
using Project.ViewModels;
using Project.Areas.Admin;

namespace Project.Controllers
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
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
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
                return Content("error");
            }

            AppUser user = new AppUser
            {
                Fullname = register.Fullname,
                Email = register.Email,
                UserName = register.Username
            };
            IdentityResult identityResult = await _userManager.CreateAsync(user, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(user, Helper.Roles.Admin.ToString());
            return RedirectToAction("Index","Home");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);

            AppUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email ve ya parol sehvdir");
                return View(login);
            }

            var signInResult = await _signInManager.PasswordSignInAsync(user, login.Password, false, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email ve ya parol sehvdir");
                return View(login);
            }

            string role = (await _userManager.GetRolesAsync(user))[0];
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task CreateRole()
        {
            if ((!await _roleManager.RoleExistsAsync(Helper.Roles.Admin.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Admin.ToString()));
            }

            if ((!await _roleManager.RoleExistsAsync(Helper.Roles.Member.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Member.ToString()));
            }
            if ((!await _roleManager.RoleExistsAsync(Helper.Roles.Moderator.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Moderator.ToString()));
            }
        }
    }
}