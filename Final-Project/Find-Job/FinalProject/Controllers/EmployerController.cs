using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class EmployerController : Controller
    {
        private readonly AppDbContext _db;

        public EmployerController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Company> model = _db.Companies.Include(c => c.Jobs);
            return View(model);
        }
        [Route("Employer/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            Company company = await _db.Companies.Include(c => c.Jobs).FirstOrDefaultAsync(c => c.Slug == slug);
            if (company == null) return NotFound();
            ViewBag.Jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).
                            Where(j => j.CompanyId == company.Id);
            return View(company);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Company> companies;
            if (String.IsNullOrEmpty(search))
            {
                companies = _db.Companies.Include(c=>c.Jobs);
            }
            else
            {
                companies = _db.Companies.Include(c => c.Jobs).Where(c=>c.Name.Contains("a"));
            }
            SearchVM model = new SearchVM
            {
                Companies=companies
            };
            return PartialView("_SearchPartial", model);
        }

        public IActionResult Sort(string sort)
        {
            IEnumerable<Company> companies=_db.Companies.Include(c=>c.Jobs);
            if(sort=="old")
            {
                companies = _db.Companies.Include(c => c.Jobs).OrderByDescending(c => c.Id);
            }
            SearchVM model = new SearchVM
            {
                Companies=companies
            };
            return PartialView("_SearchPartial",model);
        }
    }
}