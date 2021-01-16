using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public HeaderViewComponent(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Count = 0;
            ViewBag.Products = null;
            ViewBag.Total = 0;
            string basketExist = Request.Cookies["Basket"];
            List<BasketVM> products;
            if (basketExist != null)
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basketExist);
                foreach (BasketVM product in products)
                {
                    ViewBag.Total += product.Count * product.Price;
                }
                ViewBag.Count = products.Count;
                ViewBag.Products = products;
            }
            return View(await Task.FromResult(_db));
        }
    }
}
