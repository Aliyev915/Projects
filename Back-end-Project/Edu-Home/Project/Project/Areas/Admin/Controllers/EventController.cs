using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Extensions;
using Project.Helpers;
using Project.Models;
using Project.ViewModels;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public EventController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Event> eventDb = _db.Events.Include(ev=>ev.EventSpeakers).Include(c => c.Category);
            ViewBag.Speakers = _db.EventSpeakers.Include(s => s.Speaker).Include(s => s.Event);
            return View(eventDb);
        }

        public async Task<IActionResult> Info(int? Id)
        {
            if (Id == null) return NotFound();
            Event eventDb = await _db.Events.Include(ev=> ev.Category).Include(ev=>ev.EventSpeakers).
                            FirstOrDefaultAsync(ev => ev.Id == Id);
            if (eventDb == null) NotFound();
            ViewBag.Speakers = _db.EventSpeakers.Where(ev => ev.EventId == eventDb.Id).Include(es=>es.Speaker);
            return View(eventDb);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Speakers = _db.Speakers;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateEventVM ev)
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Speakers = _db.Speakers;
            if (!ModelState.IsValid)
            {
                return View(ev);
            }
        Category category = _db.Categories.FirstOrDefault(c => c.CategoryName == ev.Category);
        Event newEvent = new Event
        {
            Name = ev.EventName,
            About = ev.About,
            Place = ev.Place,
            StartTime = $"{ev.StartTime.Hour} : {ev.StartTime.Minute} {ev.StartTime.ToString("tt",CultureInfo.InvariantCulture)}",
            EndTime = $"{ev.EndTime.Hour} : {ev.EndTime.Minute}  {ev.EndTime.ToString("tt", CultureInfo.InvariantCulture)}",
            Time = $"{ev.Time.Day}, {ev.Time.ToString("MMMM")} {ev.Time.Year}",
        };
            newEvent.CategoryId = category.Id;
            if (ev.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select a photo!");
                return View();
            }
            if (!ev.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please, select correct file format!");
                return View(ev);
            }
            if (ev.Photo.Length(250))
            {
                ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                return View(ev);
            }
            newEvent.Image = await ev.Photo.GetImagePath(_env.WebRootPath, @"img\event\");
            _db.Events.Add(newEvent);
            string[] speakers = ev.Speaker.Split(',');
            List<EventSpeaker> eventSpeakers = new List<EventSpeaker>();
            foreach (string speak in speakers)
            {
                Speaker speaker = _db.Speakers.Include(s => s.EventSpeakers).FirstOrDefault(s => s.Fullname == speak);
                eventSpeakers.Add(new EventSpeaker
                {
                    EventId = newEvent.Id,
                    SpeakerId = speaker.Id
                });
            }
            foreach (EventSpeaker item in eventSpeakers)
            {
                _db.EventSpeakers.Add(item);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Speakers = _db.Speakers;
            if (Id == null) return NotFound();
            Event eve = await _db.Events.Include(ev=>ev.Category).FirstOrDefaultAsync(ev=>ev.Id==Id);
            if (eve == null) return NotFound();
            IEnumerable<EventSpeaker> speakers = _db.EventSpeakers.Where(es => es.Event.Id == Id).Include(es => es.Speaker).
                                    Include(es=>es.Speaker);
            EventVM model = new EventVM
            {
                EventSpeakers = speakers,
                Event = eve,
                Category = eve.Category,
                Tags = _db.Tags,
                Blogs = _db.Blogs
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? Id,EventVM eve)
        {
            if (Id == null) return NotFound();
            Event eventDb = await _db.Events.Include(c => c.Category).Include(c => c.EventSpeakers).FirstOrDefaultAsync(c => c.Id == Id);
            if (eventDb == null) return NotFound();
            Category category = _db.Categories.FirstOrDefault(c => c.CategoryName == eve.Category.CategoryName);
            eventDb.CategoryId = category.Id;
            eventDb.Name = eve.Event.Name;
            eventDb.About = eve.Event.About;
            eventDb.StartTime = eve.Event.StartTime;
            eventDb.EndTime = eve.Event.EndTime;
            eventDb.Time = eve.Event.Time;
            eventDb.Place = eve.Event.Place;
            if (eve.Event.Photo != null)
            {
                ModelState.AddModelError("Photo", "Please, select a photo!");
                if (!eve.Event.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please, select correct file format!");
                    return View(eventDb);
                }
                if (eve.Event.Photo.Length(250))
                {
                    ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                    return View(eventDb);
                }
                Helper.DeleteImg(eventDb.Image, _env.WebRootPath, @"img\event\");
                eventDb.Image = await eve.Event.Photo.GetImagePath(_env.WebRootPath, @"img\event\");
            }
            if (eve.Speakers != null)
            {
                string[] speakers = eve.Speakers.Split(',');
                List<EventSpeaker> eventSpeakers = new List<EventSpeaker>();
                foreach (string speak in speakers)
                {
                    Speaker speaker = _db.Speakers.Include(s => s.EventSpeakers).FirstOrDefault(s => s.Fullname == speak);
                    eventSpeakers.Add(new EventSpeaker
                    {
                        EventId = eventDb.Id,
                        SpeakerId = speaker.Id
                    });
                }
                eventDb.EventSpeakers = eventSpeakers;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Event eve = _db.Events.Include(ev => ev.EventSpeakers).FirstOrDefault(ev => ev.Id == Id);
            if (eve == null) return NotFound();
            return View(eve);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Event eve = _db.Events.Include(ev => ev.EventSpeakers).FirstOrDefault(ev => ev.Id == Id);
            if (eve == null) return NotFound();
            Helper.DeleteImg(eve.Image, _env.WebRootPath, @"img\event");
            IEnumerable<EventSpeaker> eventSpeakers = eve.EventSpeakers;
            if (eventSpeakers != null)
            {
                foreach (EventSpeaker item in eventSpeakers)
                {
                    _db.EventSpeakers.Remove(item);
                }
                _db.Events.Remove(eve);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}