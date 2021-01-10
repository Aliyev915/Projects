using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Extensions;
using FinalProject.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
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
            IEnumerable<Blog> model = _db.Blogs;
            return View(model);
        }

        #region CreateBlog
        public IActionResult Create()
        {
            ViewBag.Types = _db.BlogTypes;
            ViewBag.Tags = _db.Tags;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogVM blog)
        {
            ViewBag.Types = _db.BlogTypes;
            ViewBag.Tags = _db.Tags;
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (blog.Photo == null)
            {
                ModelState.AddModelError("Photo","The Photo is Required");
                return View();
            }
            if (blog.Photo.FileName.Length > 250)
            {
                ModelState.AddModelError("Photo", "The Photo is greater than 250px");
                return View();
            }
            if (!blog.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Select an image file");
                return View();
            }
            BlogType type = await _db.BlogTypes.FirstOrDefaultAsync(bt => bt.Type == blog.Type);
            Blog newBlog = new Blog
            {
                Title = blog.Title,
                Description = blog.Description,
                BlogTypeId = type.Id,
                Time = DateTime.Today
            };
            List<BlogTag> blogTags = new List<BlogTag>();
            if (blog.Tags == null)
            {
                return View();
            }
            foreach (string item in blog.Tags)
            {
                Tag tag = await _db.Tags.FirstOrDefaultAsync(t => t.Name == item);
                blogTags.Add(new BlogTag
                {
                    BlogId = newBlog.Id,
                    TagId = tag.Id
                });
            }

            foreach (BlogTag item in blogTags)
            {
                _db.BlogTags.Add(item);
            }
            newBlog.Image = await blog.Photo.CopyImage( _env.WebRootPath, @"img\blog\");
            newBlog.BlogTags = blogTags;
            _db.Blogs.Add(newBlog);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int? Id)
        {
            ViewBag.Types = _db.BlogTypes;
            ViewBag.Tags = _db.Tags;
            Blog blog = await _db.Blogs.Include(b=>b.BlogTags).Include(b=>b.BlogType).FirstOrDefaultAsync(b=>b.Id==Id);
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? Id,Blog blog)
        {
            ViewBag.Types = _db.BlogTypes;
            ViewBag.Tags = _db.Tags;
            Blog editedBlog = await _db.Blogs.Include(b => b.BlogTags).Include(b => b.BlogType).FirstOrDefaultAsync(b => b.Id == Id);
            BlogType type = await _db.BlogTypes.FirstOrDefaultAsync(bt => bt.Type == blog.BlogType.Type);
            editedBlog.BlogType = type;
            editedBlog.Title = blog.Title;
            editedBlog.Description = blog.Description;
            if (blog.Photo != null)
            {
                if (blog.Photo.FileName.Length > 250)
                {
                    ModelState.AddModelError("Photo", "The Photo is greater than 250px");
                    return View(editedBlog);
                }
                if (!blog.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Select an image file");
                    return View(editedBlog);
                }
                Helper.DeleteImage(editedBlog.Image);
                editedBlog.Image=await blog.Photo.CopyImage(_env.WebRootPath,@"img\blog\");
                
            }
            List<BlogTag> blogTags = _db.BlogTags.Include(bt=>bt.Tag).Where(bt => bt.BlogId == editedBlog.Id).ToList();
            if (HttpContext.Request.Form["BlogTags"].Count!=0)
            {
                blogTags.Clear();
                foreach (string item in HttpContext.Request.Form["BlogTags"])
                {
                    Tag tag = await _db.Tags.FirstOrDefaultAsync(t => t.Name == item);
                    blogTags.Add(new BlogTag
                    {
                        BlogId = editedBlog.Id,
                        TagId = tag.Id
                    });
                }
            }
            editedBlog.BlogTags = blogTags;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blog = await _db.Blogs.FindAsync(Id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blog = await _db.Blogs.FindAsync(Id);
            if (blog == null) return NotFound();
            Helper.DeleteImage(blog.Image);
            _db.Blogs.Remove(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}