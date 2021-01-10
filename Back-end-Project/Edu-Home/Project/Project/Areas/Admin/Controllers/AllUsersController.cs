using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Helpers;
using Project.Models;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AllUsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AllUsersController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            List<AppUser> existUsers = _userManager.Users.Where(u => u.IsDeleted == false).ToList();
            List<UserVM> users = new List<UserVM>();
            foreach (AppUser existUser in existUsers)
            {
                UserVM user = new UserVM
                {
                    Email = existUser.Email,
                    Fullname = existUser.Fullname,
                    Username = existUser.UserName,
                    Role = (await _userManager.GetRolesAsync(existUser))[0]
                };
                users.Add(user);
            }
            return View(users);
        }

        public IActionResult Create()
        {
            ViewBag.Roles = Enum.GetValues(typeof(Helper.Roles));
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserVM user)
        {
            ViewBag.Role = Helper.Roles.Admin;
            if (!ModelState.IsValid) return View(user);

            AppUser newUser = new AppUser
            {
                Email = user.Email,
                Fullname = user.Fullname,
                UserName = user.Username
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, user.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View(user);
                }
            }

            await _userManager.AddToRoleAsync(newUser, user.Role);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(string username)
        {
            if (username == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(username);
            UserVM userVM = new UserVM
            {
                Email = user.Email,
                Fullname = user.Fullname,
                Username = user.UserName,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View(userVM);
        }

        public async Task<IActionResult> Delete(string username)
        {
            if (username == null) return NotFound();

            AppUser user = await _userManager.FindByNameAsync(username);
            UserVM userVM = new UserVM
            {
                Email = user.Email,
                Fullname = user.Fullname,
                Username = user.UserName,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View(userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(string username)
        {
            if (username == null) return NotFound();

            AppUser user = await _userManager.FindByNameAsync(username);
            UserVM userVM = new UserVM
            {
                Email = user.Email,
                Fullname = user.Fullname,
                Username = user.UserName,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == user)
            {
                ModelState.AddModelError("", "Daxil oldugunuz hesabi sile bilmezsiniz");
                return View(userVM);
            }

            //await _userManager.DeleteAsync(user);

            user.IsDeleted = true;
            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string username)
        {
            AppUser user = await _userManager.FindByNameAsync(username);
            UserVM userVM = new UserVM
            {
                Email = user.Email,
                Fullname = user.Fullname,
                Username = user.UserName,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View(userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost(string username, UserVM userVM)
        {
            AppUser user = await _userManager.FindByNameAsync(username);
            user.Fullname = userVM.Fullname;
            user.UserName = userVM.Username;


            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Change(string username)
        {

            ViewBag.Roles = Enum.GetValues(typeof(Helper.Roles));
            AppUser user = await _userManager.FindByNameAsync(username);
            UserVM userVM = new UserVM
            {
                Email = user.Email,
                Fullname = user.Fullname,
                Username = user.UserName,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View(userVM);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Change(UserVM userVM, string username)
        {
            AppUser user = await _userManager.FindByNameAsync(username);
            await _userManager.RemoveFromRoleAsync(user, (await _userManager.GetRolesAsync(user))[0]);
            await _userManager.AddToRoleAsync(user, userVM.Role);

            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUser == user)
            {
                ModelState.AddModelError("", "Daxil oldugunuz hesabi selahiyyetlerini deyise bilmezsiniz");
                return View(userVM);
            }

            await _userManager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeletedUser()
        {
            List<AppUser> existUsers = _userManager.Users.Where(u => u.IsDeleted == true).ToList();
            List<UserVM> users = new List<UserVM>();
            foreach (AppUser existUser in existUsers)
            {
                UserVM user = new UserVM
                {
                    Email = existUser.Email,
                    Fullname = existUser.Fullname,
                    Username = existUser.UserName,
                    Role = (await _userManager.GetRolesAsync(existUser))[0]
                };
                users.Add(user);
            }
            return View(users);
        }
    }
}