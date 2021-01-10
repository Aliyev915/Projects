using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
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
            IEnumerable<Blog> model;
            ViewBag.Page = Id;
            ViewBag.Blogs = _db.Blogs.Count();
            ViewBag.Categories = _db.BlogTypes;
            ViewBag.BlogCount = _db.Blogs.Include(c => c.BlogType);
            ViewBag.Tags = _db.Tags;
            ViewBag.Latest = _db.Blogs.OrderByDescending(b=>b.Id).Take(3);
            if (Id == null)
            {
                model = _db.Blogs.Include(b => b.Comments).Take(4);
            }
            else
            {
                model = _db.Blogs.Include(b => b.Comments).Skip((int.Parse(Id.ToString())-1) * 4).Take(4);
            }
            return View(model);
        }
        [Route("Blog/Details/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            ViewBag.Blogs = _db.Blogs.OrderByDescending(b=>b.Id).Take(3);
            ViewBag.Tags = _db.Tags;
            ViewBag.Categories = _db.BlogTypes;
            ViewBag.BlogCount = _db.Blogs.Include(b=>b.BlogType);
            if (slug == null) return NotFound();
            Blog blog = _db.Blogs.Include(b=>b.BlogTags).Include(b=>b.BlogType).FirstOrDefault(b=>b.Slug.Trim()==slug);
            ViewBag.BlogTags = _db.BlogTags.Include(bt=>bt.Tag).Where(bt => bt.BlogId==blog.Id);
            ViewBag.Comments = _db.Comments.Include(c => c.AppUser).Include(c => c.Blog).Where(c=>c.BlogId==blog.Id);
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            }
            Comment comment = _db.Comments.Include(r => r.AppUser).
                    FirstOrDefault(r => r.BlogId == blog.Id && r.AppUserId == r.AppUser.Id);
            if (comment != null)
            {
                ViewBag.User = await _usermanager.FindByIdAsync(comment.AppUser.Id);
            }
            if (blog == null) NotFound();
            BlogDetailVM model = new BlogDetailVM();
            model.Blog = blog;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        [Route("Blog/Details/{slug}")]
        public async Task<IActionResult> Detail(string slug,BlogDetailVM model)
        {
            ViewBag.Blogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3);
            if (slug == null) return NotFound();
            Blog blog = _db.Blogs.Include(b => b.BlogTags).Include(b => b.BlogType).FirstOrDefault(b => b.Slug == slug) ;
            ViewBag.Tags = _db.BlogTags.Include(bt => bt.Tag).Where(bt => bt.BlogId == blog.Id);
            if (blog == null) NotFound();
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account"); 
            }
            AppUser currentUser = await _usermanager.FindByNameAsync(User.Identity.Name);
            Comment comment = new Comment
            {
                AppUserId=currentUser.Id,
                BlogId=blog.Id,
                Text=model.Message,
                Time=DateTime.Now
            };
            if (model.Reply != null)
            {
                comment.Reply = int.Parse(model.Reply.ToString());
            }
            await _db.Comments.AddAsync(comment);
            await _db.SaveChangesAsync();
            return RedirectToAction("Detail");
        }
        [Authorize]
        public IActionResult Reply(int? Id)
        {
            Message message = _db.Messages.FirstOrDefault(m => m.Id == Id);
            BlogDetailVM model = new BlogDetailVM
            {
                Reply=message.Id
            };
            return PartialView("_ReplyPartial",model);
        }
        [Route("Blog/Search/{search}")]
        public IActionResult Search(string search)
        {
            ViewBag.Latest = _db.Blogs.OrderByDescending(b => b.Id).Take(3);
            IEnumerable<Blog> blogs;
            if (String.IsNullOrEmpty(search))
            {
                blogs = _db.Blogs.Include(b => b.Comments).Take(4);
            }
            else
            {
                blogs=_db.Blogs.Include(b => b.Comments).Where(b => b.Title.Contains(search));
            }
            SearchVM model = new SearchVM
            {
                Blogs=blogs
            };
            return PartialView("_SearchPartial",model);
        }
        [Route("Blog/{tag}")]
        public IActionResult TagSearch(string tag)
        {
            ViewBag.Latest = _db.Blogs.OrderByDescending(b => b.Id).Take(3);
            ViewBag.Categories = _db.BlogTypes;
            ViewBag.Tags = _db.Tags;
            ViewBag.BlogCount = _db.Blogs.Include(b=>b.BlogType);
            Tag tg = _db.Tags.Include(t => t.BlogTags).FirstOrDefault(t=>t.Name==tag);
            if (tg == null) return NotFound();
            IEnumerable<Blog> model = _db.Blogs.Include(b=>b.BlogTags).Include(b=>b.Comments).
                                        Where(b=>b.BlogTags.FirstOrDefault(bt=>bt.TagId==tg.Id).TagId==tg.Id);
            return View(model);
        }
    }
}