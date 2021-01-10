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
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MessageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public MessageController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public async Task<IActionResult> Index()
        {
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            ViewBag.Role = (await _usermanager.GetRolesAsync(user))[0];
            ViewBag.Candidate = _db.Candidates.FirstOrDefault(c=>c.AppUserId==user.Id);
            IEnumerable<Message> model = _db.Messages.Include(m=>m.AppUser).Where(m=>m.GoMessage==user.Id);
            return View(model);
        }
        public async Task<IActionResult> ReadAll()
        {
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            IEnumerable<Message> model = _db.Messages.Include(m => m.AppUser).Where(m => m.GoMessage == user.Id);
            foreach (Message message in model)
            {
                if (model.Where(m=>m.IsRead==true).Count()>0)
                {
                    message.IsRead = false;
                }
                else
                {
                    message.IsRead = true;
                }
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Read(int? Id)
        {
            Message message = await _db.Messages.FindAsync(Id);
            if (message.IsRead)
            {
                message.IsRead = false;
            }
            else
            {
                message.IsRead = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Reply(int? Id)
        {
            Message message = await _db.Messages.Include(m=>m.AppUser).FirstOrDefaultAsync(m=>m.Id==Id);
            MessageVM model = new MessageVM
            {
                Name=message.AppUser.Email
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reply(int? Id,MessageVM model)
        {
            Message currentMessage = await _db.Messages.FindAsync(Id);
            AppUser from = await _usermanager.FindByNameAsync(User.Identity.Name);
            AppUser to = await _usermanager.FindByEmailAsync(model.Name);
            currentMessage.IsRead = true;
            Message message = new Message
            {
                AppUserId = from.Id,
                GoMessage = to.Id,
                Text = model.Text,
                Time = DateTime.Now
            };
            await _db.Messages.AddAsync(message);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteMessage(int? Id)
        {
            Message message = await _db.Messages.FindAsync(Id);
            _db.Messages.Remove(message);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}