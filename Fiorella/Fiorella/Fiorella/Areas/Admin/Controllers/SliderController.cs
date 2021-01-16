using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL;
using Fiorella.Helpers;
using Fiorella.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public SliderController(IHostingEnvironment env,AppDbContext db)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Slider> sliders = _db.Sliders;
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider.Photos == null)
            {
                ModelState.AddModelError("Photos", "Please, select image!");
                return View();
            }
            foreach (IFormFile photo in slider.Photos)
            {
                if (!photo.ContentType.Contains("image"))
                {
                    ModelState.AddModelError("Photos", "Please, select an image format!");
                    return View(slider);
                }
                if (photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photos", "The size of image is greater than 200mb!");
                    return View(slider);
                }
                string path = Path.Combine(_env.WebRootPath, @"img");
                string filename = Guid.NewGuid().ToString()+ photo.FileName;
                string fullpath = Path.Combine(path, filename);
                using (FileStream stream=new FileStream(fullpath,FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }
                Slider newSlider = new Slider { Image = filename };
                _db.Sliders.Add(newSlider);
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? Id)
        {
            if (Id == null) return NotFound();
            Slider slider = _db.Sliders.Find(Id);
            if (slider == null) NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Slider slider,int Id)
        {
            Slider sliderDb = _db.Sliders.Find(Id);
            if (slider.Photos != null)
            {
                IFormFile photo = slider.Photos[0];
                if (!photo.ContentType.Contains("image"))
                {
                    ModelState.AddModelError("Photos", "Please, select an image format!");
                    return View(sliderDb);
                }
                if (photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photos", "The size of image is greater than 200mb!");
                    return View(sliderDb);
                }
                Helper.DeleteImage(sliderDb.Image, _env.WebRootPath, "img");
                string path = Path.Combine(_env.WebRootPath, @"img");
                string filename = Guid.NewGuid().ToString() + photo.FileName;
                string fullpath = Path.Combine(path, filename);
                using (FileStream stream = new FileStream(fullpath, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }
                sliderDb.Image = filename;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(Id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(Id);
            if (slider == null) return NotFound();
            Helper.DeleteImage(slider.Image, _env.WebRootPath, "img");
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}