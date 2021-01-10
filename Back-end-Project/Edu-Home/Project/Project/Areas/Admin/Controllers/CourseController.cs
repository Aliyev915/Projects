using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Extensions;
using Project.Helpers;
using Project.Models;
using Project.ViewModels;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _usermanager;
        public CourseController(AppDbContext db,IHostingEnvironment env, UserManager<AppUser> usermanager)
        {
            _db = db;
            _env = env;
            _usermanager = usermanager;
        }
        [Authorize(Roles = "Admin,Moderator")]
        public IActionResult Index()
       {
            IEnumerable<Course> courseDb = _db.Courses.Include(c => c.CourseFeatures).Include(c => c.Category);
            return View(courseDb);
       }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Info(int? Id)
        {
            if (Id == null) return NotFound();
            Course courseDb = await _db.Courses.Include(c=>c.Category).Include(c=>c.CourseFeatures).FirstOrDefaultAsync(c=>c.Id==Id);
            if (courseDb == null) NotFound();
            return View(courseDb);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Users= await _usermanager.GetUsersInRoleAsync("Moderator");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateCourseVM course )
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Users = await _usermanager.GetUsersInRoleAsync("Moderator");
                Course newCourse = new Course
                {
                    Title = course.Title,
                    Description = course.Description,
                    Photo = course.Photo
                };
                Category category = _db.Categories.FirstOrDefault(c => c.CategoryName == course.Category);
                newCourse.CategoryId = category.Id;
                CourseFeature courseFeature = new CourseFeature
                {
                    About = course.About,
                    Apply = course.Apply,
                    Certification = course.Certification,
                    Assestement = course.Assestement,
                    Duration = course.Duration,
                    ClassDuration = course.ClassDuration,
                    Fee = course.Fee,
                    StartTime = course.StartTime,
                    Student = course.Student,
                    SkillLevel = course.SkillLevel
                };
                AppUser user = await _usermanager.FindByNameAsync(course.Fullname);
                newCourse.AppUserId = user.Id;
                if (course.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Please, select a photo!");
                    return View();
                }
                if (!course.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please, select correct file format!");
                    return View(course);
                }
                if (course.Photo.Length(250))
                {
                    ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                    return View(course);
                }
                newCourse.Image = await course.Photo.GetImagePath(_env.WebRootPath, @"img\course\");
                _db.CourseFeatures.Add(courseFeature);
                newCourse.CourseFeaturesId = courseFeature.Id;
                await _db.Courses.AddAsync(newCourse);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles ="Admin,Moderator")]
        public async Task<IActionResult> Edit(int? Id)
        {
            ViewBag.Categories = _db.Categories;
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            if (Id == null) return NotFound();
            Course course;
            course = await _db.Courses.Include(c=>c.Category).Include(c=>c.CourseFeatures).
                    FirstOrDefaultAsync(c=>c.Id==Id && c.AppUserId==user.Id);
            if (course == null) return NotFound();
            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> Edit(int? Id,Course course)
        {
            if (Id == null) return NotFound();
            Course courseDb = await _db.Courses.Include(c => c.Category).Include(c => c.CourseFeatures).
                        FirstOrDefaultAsync(c => c.Id == Id);
            if (courseDb == null) return NotFound();
            Category category = _db.Categories.FirstOrDefault(c => c.CategoryName == course.Category.CategoryName);
            courseDb.CategoryId = category.Id;
            courseDb.Title = course.Title;
            courseDb.Description = course.Description;
            courseDb.CourseFeatures = course.CourseFeatures;

            if (course.Photo != null)
            {
                ModelState.AddModelError("Photo", "Please, select a photo!");
                if (!course.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please, select correct file format!");
                    return View(courseDb);
                }
                if (course.Photo.Length(250))
                {
                    ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                    return View(courseDb);
                }
                Helper.DeleteImg(courseDb.Image, _env.WebRootPath, @"img\course\");
                courseDb.Image = await course.Photo.GetImagePath(_env.WebRootPath, @"img\course\");
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Course course = await _db.Courses.Include(c => c.Category).Include(c => c.CourseFeatures).FirstOrDefaultAsync(c => c.Id == Id);
            if (course == null) return NotFound();
            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Course course = await _db.Courses.FirstOrDefaultAsync(c => c.Id == Id);
            if (course == null) return NotFound();
            Helper.DeleteImg(course.Image, _env.WebRootPath, @"img\course");
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}