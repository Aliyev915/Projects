using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Project.DAL;
using Project.Models;
using Project.Extensions;
using Project.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db,IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            var model = _db.Sliders;
            return View(model);
        }

        public async Task<IActionResult> Info(int? Id)
        {
            if (Id == null) NotFound();
            Slider model =await _db.Sliders.FindAsync(Id);
            if (model == null) NotFound();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider.Photos==null)
            {
                ModelState.AddModelError("Photos", "Please, select a photo!");
                return View();
            }
            foreach (IFormFile Photo in slider.Photos)
            {
                if (!Photo.IsImage())
                {
                    ModelState.AddModelError("Photos", "Please, select correct file format!");
                    return View(slider);
                }
                if (Photo.Length(250))
                {
                    ModelState.AddModelError("Photos", "An image must not be 250 kb more than!");
                    return View(slider);
                }
                string image = Path.Combine(_env.WebRootPath, @"img\slider");
                string filename = Guid.NewGuid().ToString() + Photo.FileName;
                string fullPath = Path.Combine(image, filename);
                using(FileStream stream=new FileStream(fullPath, FileMode.Create))
                {
                    await Photo.CopyToAsync(stream);
                }
                Slider newSlider = new Slider { Image=filename};
                await _db.Sliders.AddAsync(newSlider);
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Slider setting = await _db.Sliders.FindAsync(Id);
            if (setting == null) return NotFound();
            return View(setting);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(Id);
            if (slider == null) return NotFound();
            Helper.DeleteImg(slider.Image, _env.WebRootPath, @"img\slider\");
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null) return NotFound();
            Slider setting = await _db.Sliders.FindAsync(Id);
            if (setting == null) return NotFound();
            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Slider slider,int? Id)
        {
                if (Id == null) return View();
                Slider dbSlider = await _db.Sliders.FindAsync(Id);
                if (slider.Photos != null)
                {
                    IFormFile Photo = slider.Photos[0];
                if (!Photo.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Please, select correct file format!");
                        return View(dbSlider);
                    }
                    if (Photo.Length(250))
                    {
                        ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                        return View(dbSlider);
                    }
                    Helper.DeleteImg(dbSlider.Image, _env.WebRootPath, @"img\slider\");
                    dbSlider.Image = await Photo.GetImagePath(_env.WebRootPath, @"img\slider\");
                    await _db.SaveChangesAsync();
                }
            return RedirectToAction("Index");
        }
        public IActionResult Content()
        {
            Setting model = _db.Settings.FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Content(Setting setting)
        {
            Setting dbSetting = _db.Settings.FirstOrDefault();
            if (dbSetting != null)
            {
                dbSetting.Title = setting.Title;
                dbSetting.Description = setting.Description;
            }
            Setting newSetting = new Setting
            {
                Title=setting.Title,
                Description=setting.Description
            };
            _db.Settings.Add(newSetting);
            await _db.SaveChangesAsync();
            ViewBag.Description = setting.Description;
            return RedirectToAction(nameof(Content));
        }

    }
}