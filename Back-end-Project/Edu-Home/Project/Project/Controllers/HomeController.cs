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
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public HomeController(AppDbContext db,UserManager<AppUser> userManager)
        {
            _db = db;
            _usermanager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = user;
            }
            HomeVM model = new HomeVM
            {
                Setting = _db.Settings.FirstOrDefault(),
                Sliders=_db.Sliders,
                Blogs = _db.Blogs,
                Content = _db.Content.FirstOrDefault(),
                Courses = _db.Courses,
                Events = _db.Events,
                Imotional=_db.Imotional.FirstOrDefault(),
                Notices=_db.Notices
            };
            return View(model);
        }

        public async Task<IActionResult> Subscribe()
        {
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            if (user.IsSubscribed)
            {
                user.IsSubscribed = false;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("sadigcop@gmail.com");
                mail.To.Add(user.Email);
                mail.Subject = "You subscribed";
                mail.Body = $"<h2>{user.Fullname}</h2> <p>UnSubscribed</p>";
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
                mail.Subject = "You subscribed";
                mail.To.Add(user.Email);
                mail.Body = $"<h2>{user.Fullname}</h2> <p>subscribed</p>";
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