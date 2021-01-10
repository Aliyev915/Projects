using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.DAL;
using Project.Models;
using Microsoft.EntityFrameworkCore;
using Project.ViewModels;
using System.Net.Mail;
using System.Net;

namespace Project.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Event> model = _db.Events;
            return View(model);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            ViewBag.Categories = _db.Categories.Include(c=>c.Events);
            if (Id == null) return NotFound();
            Event eve = await _db.Events.FindAsync(Id);
            if(eve==null) return NotFound();
            IEnumerable<EventSpeaker> speakers = _db.EventSpeakers.Where(es => es.Event.Id == Id).Include(es => es.Speaker);
            EventVM model = new EventVM
            {
                EventSpeakers=speakers,
                Event=eve,
                Tags=_db.Tags,
                Blogs=_db.Blogs
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int? Id, EventVM ev)
        {
            if (Id == null) return NotFound();
            Event eve = await _db.Events.FindAsync(Id);
            if (eve == null) return NotFound();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("sadigcop@gmail.com");
            mail.To.Add(ev.Email);
            mail.Subject = ev.Subject;
            mail.Body = $"<h2>Mail to {ev.Name}</h2> <p>{ev.Message}</p>";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("sadigcop@gmail.com", "Sadig12345");
            smtp.Send(mail);

            return RedirectToAction("Details");
        }

        public async Task<IActionResult> Categories(int? Id)
        {
            if (Id == null) return NotFound();
            Category category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == Id);
            if (category == null) return NotFound();
            ViewBag.DataId = category.Id;
            IEnumerable<Event> events = _db.Events.Include(ev=>ev.EventSpeakers).Where(b => b.CategoryId == category.Id);
            return View(events);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Event> events = _db.Events.Where(c => c.Name.Contains(search)).OrderByDescending(c => c.Id).Take(5);
            SearchVM model = new SearchVM
            {
                Events = events
            };
            return PartialView("_SearchPartial", model);
        }

        public IActionResult Result(string search)
        {
            IEnumerable<Event> events = _db.Events.Where(c => c.Name.Contains(search));
            return View(events);
        }
    }
}