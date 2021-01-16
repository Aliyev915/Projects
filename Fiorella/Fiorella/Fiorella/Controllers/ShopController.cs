using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fiorella.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public ShopController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public IActionResult Index()
        {
            string basket=Request.Cookies["Basket"];
            List<BasketVM> basketProducts=null;
            if (basket != null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            ViewBag.Basket = basketProducts;
            IEnumerable<Product> products= _db.Products.Include(p => p.Category);
            if (basketProducts != null)
            {
                foreach (BasketVM product in basketProducts)
                {
                    products = products.Where(p => p.Id != product.Id);
                }
            }
            return View(products);
        }
        public async Task<IActionResult> Buy(int? Id)
        {
            Product product =await _db.Products.FindAsync(Id);
            string basket = Request.Cookies["Basket"];
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            Shopping shopping = new Shopping 
            {
                Time=DateTime.Now,
                ProductId=product.Id,
                AppUserId=user.Id
            };
            if (basket != null)
            {
                List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                var productInBasket = basketProducts.FirstOrDefault(bp => bp.Id == Id);
                shopping.Count = productInBasket.Count;
                shopping.Total = productInBasket.Count * productInBasket.Price;
                if (productInBasket != null)
                {
                    if (basketProducts.Count == 1)
                    {
                        Response.Cookies.Delete("Basket");
                    }
                    else
                    {
                        basketProducts.Remove(productInBasket);
                        Response.Cookies.Append("Basket", JsonConvert.SerializeObject(basketProducts),
                                                    new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
                    }
                }
            }
            else
            {
                shopping.Count = 1;
                shopping.Total = product.Price;
            }
            _db.Shoppings.Add(shopping);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}