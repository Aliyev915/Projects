using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.DAL;
using Project.Models;
using Project.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Project.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> model = _db.Teachers;
            return View(model);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null) return NotFound();
            Teacher teacher = await _db.Teachers.Include(t=>t.Skill).Include(t=>t.TeacherInfo).FirstOrDefaultAsync(t=>t.Id==Id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Teacher> teachers = _db.Teachers.Where(c => c.Name.Contains(search)).OrderByDescending(c => c.Id).Take(5);
            SearchVM model = new SearchVM
            {
                Teachers = teachers
            };
            return PartialView("_SearchPartial", model);
        }

        public IActionResult Result(string search)
        {
            IEnumerable<Teacher> teachers = _db.Teachers.Where(c => c.Name.Contains(search));
            return View(teachers);
        }
    }
}