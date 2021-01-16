using Fiorella.DAL;
using Fiorella.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewComponents
{
    public class Carousels:ViewComponent
    {
        private readonly AppDbContext _db;
        public Carousels(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<Carousel> model = _db.Carousels;
            return View(await Task.FromResult(model));
        }
    }
}
