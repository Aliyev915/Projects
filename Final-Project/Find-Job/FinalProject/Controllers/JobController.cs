using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Extensions;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class JobController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public JobController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public async Task<IActionResult> Index(int? Id)
        {   
            ViewBag.Categories = _db.Categories;
            ViewBag.Locations = _db.Locations;
            ViewBag.Types = _db.Types;
            ViewBag.Jobs = _db.Jobs.Count();
            ViewBag.Page = Id;
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
                ViewBag.IsMarked = _db.Bookmarks.Where(b => b.AppUserId==user.Id);
                ViewBag.User = user;
            }
            IEnumerable<Job> model;
            if (Id == null)
            {
                model = _db.Jobs.Include(j => j.Category).Include(j => j.Company).Include(j=>j.Bookmarks).
                                            Include(j => j.Location).Include(j => j.Type).OrderByDescending(j => j.Id).
                                            Take(4);
            }
            else
            {
                model = _db.Jobs.Include(j => j.Category).Include(j => j.Company).Include(j=>j.Bookmarks).
                                            Include(j => j.Location).Include(j => j.Type).OrderByDescending(j => j.Id).
                                            Skip(4*(int.Parse(Id.ToString())-1)).Take(4);
            }
            return View(model);
        }
        [Route("Job/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            Job job = await _db.Jobs.Include(j => j.Company).Include(j => j.Demand).Include(j => j.Category).Include(j=>j.Currency).
                Include(j => j.Type).
                Include(j => j.Location).FirstOrDefaultAsync(j => j.Slug.Trim() == slug);
            if (job == null) return NotFound();
            ViewBag.Jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Company).Include(j => j.Category).Include(j => j.Type).
                    Where(j => j.CategoryId == job.CategoryId);
            ViewBag.Users = _usermanager.Users.Take(5).OrderBy(u=>u.Fullname);
            MessageVM model = new MessageVM();
            model.Job = job;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Job/{slug}")]
        public async Task<IActionResult> Detail(string slug, MessageVM model)
        {
            Job job = await _db.Jobs.Include(j => j.Company).Include(j => j.Demand).Include(j => j.Category).Include(j => j.Currency).
                Include(j => j.Type).
                Include(j => j.Location).FirstOrDefaultAsync(j => j.Slug == slug);
            if (job == null) return NotFound();
            ViewBag.Jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Company).Include(j => j.Category).Include(j => j.Type).
                    Where(j => j.CategoryId == job.CategoryId);
            ViewBag.Users = _usermanager.Users.Take(5).OrderBy(u => u.Fullname);
            AppUser from = await _usermanager.FindByNameAsync(User.Identity.Name);
            AppUser to = await _usermanager.FindByEmailAsync(model.Name);
            Message message = new Message
            {
                AppUserId=from.Id,
                GoMessage=to.Id,
                Text=model.Text,
                Time=DateTime.Now
            };
            await _db.Messages.AddAsync(message);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Detail));
        }
        [Route("Job/{text}/{location}/{category}/{type}/{date}/{experience}/{salary}")]
        public IActionResult Search(string text,string location,string category,string type,
                                    string date,string experience,string salary)
        {
            ViewBag.Locations = _db.Locations;
            ViewBag.Categories = _db.Categories;
            ViewBag.Category = category;
            ViewBag.Text = text;
            ViewBag.Location = location;
            ViewBag.Types = _db.Types;
            ViewBag.Type = type;
            ViewBag.Date = date;
            ViewBag.Experience = experience;
            ViewBag.Salary = salary;
            Location loc = _db.Locations.FirstOrDefault(l=>l.Name==location);
            Category cat = _db.Categories.FirstOrDefault(c=>c.Name==category);
            Models.Type typ = _db.Types.FirstOrDefault(t=>t.Name==type);
            IEnumerable<Job> jobs= _db.Jobs.Include(j => j.Company).Include(j => j.Category).
                                Include(j => j.Location).Include(j => j.Type);
            jobs=jobs.Search(_db, text, location, category, type, date, experience, salary);
            SearchVM model = new SearchVM
            {
                Jobs = jobs
            };
            return PartialView("_SearchPartial", model);
            //return Json(model.Jobs.Count());
        }

        [Route("Job/SearchFromHome/{text}/{location}")]
        [Route("Job/SearchFromHome/{text}")]
        public IActionResult SearchFromHome(string text,string location)
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Locations = _db.Locations;
            ViewBag.Types = _db.Types;
            IEnumerable<Job> model = _db.Jobs.Include(j=>j.Company).Include(j=>j.Location).Include(j=>j.Category).
                                Include(j=>j.Category).Include(j=>j.Type).Include(j=>j.Currency);
            if (text != null && location==null)
            {
                model = model.Where(j => j.Name.Contains(text));
            }
            else if(text==null && location != null)
            {
                Location loc = _db.Locations.FirstOrDefault(l=>l.Name==location);
                model = model.Where(j => j.Location.Id==loc.Id);
            }
            else if(text!=null && location != null)
            {
                Location loc = _db.Locations.FirstOrDefault(l => l.Name == location);
                model = model.Where(j => j.Location.Id == loc.Id && j.Name.Contains(text));
            }
            return View(model);
        }
        [Route("Job/Sort/{sort}")]
        public IActionResult Sort(string sort)
        {
            IEnumerable<Job> jobs = _db.Jobs.Include(j=>j.Category).Include(j=>j.Type).
                            Include(j=>j.Company).Include(j=>j.Currency).Include(j=>j.Location).Take(4);
            if (sort == "old")
            {
                jobs = _db.Jobs.Include(j => j.Category).Include(j => j.Company).Include(j=>j.Type).
                                Include(j => j.Currency).Include(j => j.Location).OrderByDescending(c => c.Id).Take(4);
            }
            SearchVM model = new SearchVM
            {
                Jobs = jobs
            };
            return PartialView("_SearchPartial", model);
        }
        [Authorize]
        [Route("Job/BookMark/{Id}")]
        public async Task<IActionResult> BookMark(int? Id)
        {
            if (Id == null) return NotFound();
            Job job = await _db.Jobs.FindAsync(Id);
            if (job == null) return NotFound();
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            Bookmark bookmark = _db.Bookmarks.FirstOrDefault(b => b.AppUserId == user.Id && b.JobId == job.Id);
            ViewBag.IsMarked = bookmark;
            if (bookmark == null)
            {
                Bookmark newBookmark = new Bookmark
                {
                    JobId = job.Id,
                    AppUserId = user.Id
                };
                _db.Bookmarks.Add(newBookmark);
            }
            else
            {
                Bookmark book = _db.Bookmarks.FirstOrDefault(b => b.JobId == job.Id && b.AppUserId == user.Id);
                _db.Bookmarks.Remove(book);
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Route("Job/Apply/{Id}")]
        [Authorize]
        public async Task<IActionResult> Apply(int Id)
        {
            Job job = _db.Jobs.Include(j=>j.AppUser).Include(j=>j.Category).Include(j=>j.Location).FirstOrDefault(j => j.Id == Id);
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            Candidate candidate = _db.Candidates.FirstOrDefault(c=>c.AppUserId==user.Id);
            Message message = new Message
            {
                AppUserId = user.Id,
                GoMessage = job.AppUser.Id,
                Text = candidate.Fullname,
                Time = DateTime.Now
            };
            await _db.Messages.AddAsync(message);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}