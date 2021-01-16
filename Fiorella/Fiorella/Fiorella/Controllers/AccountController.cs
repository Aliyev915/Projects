using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL;
using Fiorella.Helpers;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        public AccountController(AppDbContext db,
            UserManager<AppUser> usermanager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> rolemanager)
        {
            _db = db;
            _usermanager = usermanager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
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

            AppUser user = await _usermanager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Incorrect email or Password");
                return View(login);
            }
            var signInResult = await _signInManager.PasswordSignInAsync(user, login.Password,false,true);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Incorrect email or Password");
                return View(login);
            }
            string role = (await _usermanager.GetRolesAsync(user))[0];
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);

            AppUser newUser = new AppUser
            {
                UserName=register.Username,
                Email=register.Email
            };

            IdentityResult result = await _usermanager.CreateAsync(newUser, register.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            
            await _usermanager.AddToRoleAsync(newUser, Roles.User.ToString());
            return RedirectToAction(nameof(Login));
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task CreateRole()
        {
            if(!await _rolemanager.RoleExistsAsync(Roles.Admin.ToString()))
            {
                await _rolemanager.CreateAsync(new IdentityRole (Roles.Admin.ToString()));
            }
            if (!await _rolemanager.RoleExistsAsync(Roles.User.ToString()))
            {
                await _rolemanager.CreateAsync(new IdentityRole(Roles.User.ToString()));
            }
        }
    }
}