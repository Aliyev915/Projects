using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Models;
using Project.ViewModels;

namespace Project.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _db;
        public CourseController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Course> model = _db.Courses;
            return View(model);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            ViewBag.Categories=_db.Categories.Include(c=>c.Courses);
            if (Id == null) return NotFound();
            Course course = await _db.Courses.Include(c=>c.Category).Include(c=>c.CourseFeatures).FirstOrDefaultAsync(c=>c.Id==Id);
            if (course == null) return NotFound();
            ViewBag.Categories = _db.Categories;
            ViewBag.Tags = _db.Tags;
            ViewBag.Blogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3);
            CourseVM courseVM = new CourseVM
            {
                Course = course,
                Courses = _db.Courses.Include(c => c.Category)
            };
            return View(courseVM);
        }

        public async Task<IActionResult> Categories(int? Id)
        {
            if (Id == null) return NotFound();
            Category category = await _db.Categories.Include(c=>c.Courses).FirstOrDefaultAsync(c => c.Id == Id);
            if (category == null) return NotFound();
            IEnumerable<Course> courses = _db.Courses.Include(c=>c.CourseFeatures).Include(c=>c.Category).
                Where(b => b.CategoryId == category.Id);
            ViewBag.BlogCount = courses.Count();
            CourseVM model = new CourseVM
            {
                Courses = courses,
            };
            return View(model);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Course> courses = _db.Courses.Where(c => c.Title.Contains(search)).OrderByDescending(c=>c.Id).Take(5);
            SearchVM model = new SearchVM
            {
                Courses = courses
            };
            return PartialView("_SearchPartial", model);
        }

        public IActionResult Result(string search)
        {
            IEnumerable<Course> courses = _db.Courses.Where(c => c.Title.Contains(search));
            return View(courses);
        }
    }
}