using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Extensions;
using Project.Helpers;
using Project.Models;
using Project.ViewModels;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public BlogController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Blog> blogDb = _db.Blogs.Include(c => c.Tag).Include(c => c.Category);
            return View(blogDb);
        }

        public async Task<IActionResult> Info(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blogDb = await _db.Blogs.Include(c => c.Category).Include(c => c.Tag).FirstOrDefaultAsync(c => c.Id == Id);
            if (blogDb == null) NotFound();
            return View(blogDb);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Tags = _db.Tags;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBlogVM blog)
        {
            ViewBag.Categories = _db.Categories;
            Blog newBlog = new Blog
                {
                    Description = blog.Description,
                    Photo = blog.Photo,
                    About = blog.About,
                    Date = blog.Time,
                    Author = blog.Author
                };
                Category category = _db.Categories.FirstOrDefault(c => c.CategoryName == blog.Category);
                Tag tag = _db.Tags.FirstOrDefault(c => c.TagName == blog.Tag);

                newBlog.CategoryId = category.Id;
                newBlog.TagId = tag.Id;
                if (blog.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Please, select a photo!");
                    return View();
                }
                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please, select correct file format!");
                    return View(blog);
                }
                if (blog.Photo.Length(250))
                {
                    ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                    return View(blog);
                }
                newBlog.Image = await blog.Photo.GetImagePath(_env.WebRootPath, @"img\blog\");
                await _db.Blogs.AddAsync(newBlog);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Tags = _db.Tags;
            if (Id == null) return NotFound();
            Blog blog = await _db.Blogs.Include(c => c.Category).Include(c => c.Tag).FirstOrDefaultAsync(c => c.Id == Id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? Id, Blog blog)
        {
            ViewBag.Categories = _db.Categories;
            ViewBag.Tags = _db.Tags;
            if (Id == null) return NotFound();
            Blog blogDb = await _db.Blogs.Include(c => c.Category).Include(c => c.Tag).FirstOrDefaultAsync(c => c.Id == Id);
            if (blogDb == null) return NotFound();
            blogDb.Category.CategoryName = blog.Category.CategoryName;

            blogDb.Description = blog.Description;
            blogDb.About = blog.About;
            blogDb.Author = blog.Author;
            blogDb.Date = blog.Date;

            if (blog.Photo != null)
            {
                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please, select correct file format!");
                    return View(blogDb);
                }
                if (blog.Photo.Length(250))
                {
                    ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                    return View(blogDb);
                }
                Helper.DeleteImg(blogDb.Image, _env.WebRootPath, @"img\blog");
                blogDb.Image = await blog.Photo.GetImagePath(_env.WebRootPath, @"img\blog");
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blog = await _db.Blogs.Include(b=>b.Category).Include(b=>b.Tag).FirstOrDefaultAsync(b=>b.Id==Id);
            if (blog == null) NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blog = await _db.Blogs.Include(b => b.Category).Include(b => b.Tag).FirstOrDefaultAsync(b => b.Id == Id);
            if (blog == null) NotFound();
            Helper.DeleteImg(blog.Image, _env.WebRootPath, @"img\blog");
            _db.Blogs.Remove(blog);
            return RedirectToAction("Index");
        }
    }
}