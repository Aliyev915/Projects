using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = _db.Sliders,
                Content = _db.Contents.FirstOrDefault(),
                Products = _db.Products.Include(p => p.Category),
                Categories = _db.Categories,
                Video = _db.Videos.FirstOrDefault(),
                Lists = _db.Lists,
                Professions = _db.Professions,
                Experts = _db.Experts.Include(ex => ex.Profession),
                Imotionals=_db.Imotionals.Include(i=>i.Profession),
                Carousels=_db.Carousels
            };
            return View(model);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Product> products = _db.Products.Where(p => p.Name.Contains(search));
            return PartialView("_SearchPartial", products);
        }

        public async Task<IActionResult> AddToCard(int? Id)
        {
            if (Id == null) return NotFound();
            Product product = await _db.Products.Include(p=>p.Category).FirstOrDefaultAsync(p=>p.Id==Id);
            if (product == null) return NotFound();
            string basketExist = Request.Cookies["Basket"];
            List<BasketVM> products;
            if (basketExist == null)
            {
                products = new List<BasketVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basketExist);
            }
            BasketVM productInBasket = products.FirstOrDefault(p=>p.Id==Id);
            if (productInBasket == null)
            {
                products.Add(new BasketVM 
                {
                    Id=product.Id,
                    Name=product.Name,
                    Image=product.Image,
                    Price=product.Price,
                    Count=1
                });
            }
            else
            {
                productInBasket.Count++;
            }
            string basket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("Basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(7) });
            return RedirectToAction(nameof(Index), "Home");
        }

        public IActionResult RemoveFromBasket(int? Id)
        {
            if (Id == null) return NotFound();
            string basket = Request.Cookies["Basket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM productBasket = products.FirstOrDefault(p => p.Id == Id);
            products.Remove(productBasket);
            string editedBasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("Basket", editedBasket, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}