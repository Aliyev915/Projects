using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL;
using Fiorella.Helpers;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public ProductController(AppDbContext db,IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products = _db.Products.Include(p=>p.Category);
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductVM product)
        {
            ViewBag.Categories = _db.Categories;
            Category category = _db.Categories.FirstOrDefault(c => c.Name == product.Category);
            Product newProduct = new Product
            {
                Name=product.Name,
                Price=product.Price,
            };
            if (product.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select an image!");
                return View(product);
            }
            if (!product.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photos", "Please, select an image format!");
                return View(product);
            }
            if (product.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photos", "The size of image is greater than 200mb!");
                return View(product);
            }
            newProduct.CategoryId = category.Id;
            string path = Path.Combine(_env.WebRootPath, @"img");
            string filename = Guid.NewGuid().ToString() + product.Photo.FileName;
            string fullpath = Path.Combine(path, filename);
            using (FileStream stream=new FileStream(fullpath,FileMode.Create))
            {
                await product.Photo.CopyToAsync(stream);
            }
            newProduct.Image = filename;
            await _db.Products.AddAsync(newProduct);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null) return NotFound();
            Product productDb = await _db.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == Id);
            if (productDb == null) return NotFound();
            ViewBag.Categories = _db.Categories;
            ViewBag.Product = productDb;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductVM product,int? Id)
        {
            if (Id == null) return NotFound();
            Product productDb = await _db.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == Id);
            if (productDb == null) return NotFound();
            ViewBag.Categories = _db.Categories;
            ViewBag.Product = productDb;
            productDb.Name = product.Name;
            productDb.Price = product.Price;
            if (product.Photo != null)
            {
                Helper.DeleteImage(productDb.Image, _env.WebRootPath, "img");
                string path = Path.Combine(_env.WebRootPath, @"img");
                string filename = Guid.NewGuid().ToString() + product.Photo.FileName;
                string fullpath = Path.Combine(path, filename);
                using (FileStream stream = new FileStream(fullpath, FileMode.Create))
                {
                    await product.Photo.CopyToAsync(stream);
                }
                productDb.Image = filename;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Product product = await _db.Products.Include(p=>p.Category).FirstOrDefaultAsync(p=>p.Id==Id);
            if (product == null) return NotFound();
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Product product = await _db.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == Id);
            if (product == null) return NotFound();
            Helper.DeleteImage(product.Image, _env.WebRootPath, "img");
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}