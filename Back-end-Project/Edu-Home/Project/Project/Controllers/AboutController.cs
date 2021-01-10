using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.DAL;
using Project.Models;
using Project.ViewModels;

namespace Project.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public AboutController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = user;
            }
            AboutVM model = new AboutVM
            {
                Content=_db.Content.FirstOrDefault(),
                Teachers=_db.Teachers.Take(4),
                Bio=_db.Bio.FirstOrDefault(),
                Imotional=_db.Imotional.FirstOrDefault(),
                Notices=_db.Notices,
                Settings=_db.Settings
            };
            return View(model);
        }
        public async Task<IActionResult> Subscribe()
        {
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            if (user.IsSubscribed)
            {
                user.IsSubscribed=false;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("sadigcop@gmail.com");
                mail.To.Add(user.Email);
                mail.Subject = "You unsubscribed";
                mail.Body = $"<h2>Mail to {user.Fullname}</h2> <p>is unsubscribed</p>";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("sadigcop@gmail.com", "Sadig12345");
                smtp.Send(mail);
            }
            else
            {
                user.IsSubscribed = true;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("sadigcop@gmail.com");
                mail.To.Add(user.Email);
                mail.Subject = "You subscribed";
                mail.Body = $"<h2>Mail to {user.Fullname}</h2> <p>is unsubscribed</p>";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("sadigcop@gmail.com", "Sadig12345");
                smtp.Send(mail);
            }
            await _usermanager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }
    }
}