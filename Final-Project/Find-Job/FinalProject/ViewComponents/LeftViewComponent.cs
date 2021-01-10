using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.ViewModels;
using FinalProject.Models;
using FinalProject.DAL;

namespace FinalProject.ViewComponents
{
    public class LeftViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public LeftViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ComponentVM model = new ComponentVM
            {
                Categories=_db.Categories,
                Locations=_db.Locations
            };
            return View(await Task.FromResult(model));
        }
    }
}
