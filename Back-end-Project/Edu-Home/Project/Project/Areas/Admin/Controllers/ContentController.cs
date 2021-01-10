using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Project.DAL;
using Project.Extensions;
using Project.Helpers;
using Project.Models;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContentController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public ContentController(AppDbContext db,IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            Content model = _db.Content.FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Content content)
        {
            Content model = _db.Content.FirstOrDefault();
            if(model!=null)
            {
                model.Description = content.Description;
                model.Title = content.Title;
                if (content.Photo != null)
                {
                    ModelState.AddModelError("Photo", "Please, select a photo!");
                    if (!content.Photo.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Please, select correct file format!");
                        return View(model);
                    }
                    if (content.Photo.Length(250))
                    {
                        ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                        return View(model);
                    }
                    Helper.DeleteImg(model.Image, _env.WebRootPath, @"img\about\");
                    model.Image = await content.Photo.GetImagePath(_env.WebRootPath, @"img\about\");
                }   
            }
            else
            {
                if (content.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Please, select a photo!");
                    return View();
                }
                if (!content.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please, select correct file format!");
                    return View(content);
                }
                if (content.Photo.Length(250))
                {
                    ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                    return View(content);
                }
                content.Image = await content.Photo.GetImagePath(_env.WebRootPath, @"img\about\");
                await _db.Content.AddAsync(content);
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}