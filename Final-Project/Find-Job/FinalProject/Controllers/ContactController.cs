using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public ContactController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public IActionResult Index()
        {
            Bio bio = _db.Bio.FirstOrDefault();
            MessageVM model = new MessageVM
            {
                Bio = bio
            };
            return View(model);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(MessageVM messageVM)
        {
            Bio bio = _db.Bio.FirstOrDefault();
            AppUser from = await _usermanager.FindByNameAsync(User.Identity.Name);
            AppUser to = await _usermanager.FindByNameAsync("admin01");
            Message message = new Message
            {
                AppUserId = from.Id,
                GoMessage = to.Id,
                Text = messageVM.Text,
                Time = DateTime.Now
            };
            MessageVM model = new MessageVM
            {
                Bio = bio
            };
            await _db.Messages.AddAsync(message);
            await _db.SaveChangesAsync();
            return View(model);
        }
    }
}