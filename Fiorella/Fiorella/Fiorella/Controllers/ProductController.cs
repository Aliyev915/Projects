using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL; 
using Microsoft.AspNetCore.Mvc;
using Fiorella.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM
            {
                Products = _db.Products.Include(p=>p.Category).Take(4),
                Categories=_db.Categories,
                Carousels = _db.Carousels
            };
            ViewBag.ProductCount = _db.Products.Count();
            return View(model);
        }

        public IActionResult LoadMore(int? skip)
        {
            if (skip == null) skip = 0;
            HomeVM model = new HomeVM
            {
                Categories = _db.Categories,
                Products = _db.Products.Include(p => p.Category).Skip((int)skip*4).Take(4)
            };
            ViewBag.ProductCount = skip;
            return PartialView("_LoadMore", model);
        }
    }
}