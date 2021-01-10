using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.DAL;

namespace FinalProject.Areas.Admin.ViewComponents
{
    public class SidebarViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public SidebarViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Controller=ViewContext.RouteData.Values["controller"].ToString();
            ViewBag.Action = ViewContext.RouteData.Values["action"].ToString();
            Link[] model = _db.Links.ToArray();
            return View(await Task.FromResult(model));
        }
    }
}
