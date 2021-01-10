using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Models;
using Project.ViewModels;

namespace Project.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public BlogController(AppDbContext db, UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public IActionResult Index(int? Id)
        {
            BlogVM model;
            ViewBag.Replies = _db.Replies.Include(r=>r.Blog);
            if (Id == null)
            {
                model = new BlogVM
                {
                    Blogs = _db.Blogs,
                    Categories = _db.Categories,
                    Tags = _db.Tags
                };
            }
            else
            {
                model = new BlogVM
                {
                    Blogs = _db.Blogs.Skip((int)(Id-1)*6),
                    Categories = _db.Categories,
                    Tags = _db.Tags
                };
            }
            
            ViewBag.BlogCount = _db.Blogs.Count();
            ViewBag.Blogs = _db.Blogs;
            return View(model);
        }
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blog =await _db.Blogs.FindAsync(Id);
            if (blog == null) return NotFound();
            ViewBag.Replies = _db.Replies.Include(r=>r.Blog).Include(r => r.AppUser).Where(r=>r.BlogId==blog.Id);
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
                ViewBag.Role = (await _usermanager.GetRolesAsync(user))[0];
            }
            Reply reply = _db.Replies.Include(r=>r.AppUser).FirstOrDefault(r=>r.BlogId==blog.Id && r.AppUserId==r.AppUser.Id);
            if (reply != null)
            {
                AppUser user = await _usermanager.FindByIdAsync(reply.AppUser.Id);
                ViewBag.User = user.Fullname;
            }
            BlogVM model = new BlogVM
            {
                Blogs = _db.Blogs,
                Blog = blog,
                Categories = _db.Categories,
                Tags = _db.Tags
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int? Id,BlogVM blog)
        {
            if (Id == null) return NotFound();
            Blog blogDb = await _db.Blogs.FindAsync(Id);
            if (blogDb == null) return NotFound();

            AppUser CurrentUser = await _usermanager.FindByNameAsync(User.Identity.Name);
            Reply reply = new Reply
            {
                Message = blog.Message,
                BlogId = blogDb.Id,
                Time = DateTime.Today,
                AppUserId = CurrentUser.Id
            };
            await _db.Replies.AddAsync(reply);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Details));
        }

        public async Task<IActionResult> Categories(int? Id)
        {
            if (Id == null) return NotFound();
            Category category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == Id);
            if (category == null) return NotFound();
            ViewBag.DataId = category.Id;
            IEnumerable<Blog> blogs = _db.Blogs.Where(b => b.CategoryId == category.Id);
            ViewBag.BlogCount = blogs.Count();
            BlogVM model = new BlogVM
            {
                Blogs=blogs,
                Categories=_db.Categories,
                Tags=_db.Tags,
                All=_db.Blogs
            };
            return View(model);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Blog> blogs = _db.Blogs.Where(c => c.Description.Contains(search)).OrderByDescending(c => c.Id).Take(5);
            SearchVM model = new SearchVM
            {
                Blogs = blogs
            };
            return PartialView("_SearchPartial", model);
        }

        public IActionResult Result(string search)
        {
            IEnumerable<Blog> blogs = _db.Blogs.Where(c => c.Description.Contains(search));
            return View(blogs);
        }

        public async Task<IActionResult> DeleteReply(int Id)
        {
            Reply reply = await _db.Replies.FindAsync(Id);
            _db.Replies.Remove(reply);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}