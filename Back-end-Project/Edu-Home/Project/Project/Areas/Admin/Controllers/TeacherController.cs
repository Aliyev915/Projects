using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.DAL;
using Project.Models;
using Project.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Project.Extensions;
using Project.Helpers;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public TeacherController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> model = _db.Teachers.Include(t => t.TeacherInfo).Include(t => t.Skill);
            return View(model);
        }

        public async Task<IActionResult> Info(int? Id)
        {
            if (Id == null) return NotFound();
            Teacher teacherDb = await _db.Teachers.Include(c => c.Skill).Include(c => c.TeacherInfo).FirstOrDefaultAsync(c => c.Id == Id);
            if (teacherDb == null) NotFound();
            return View(teacherDb);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTeacherVM teacher)
        {
            Teacher newTeacher = new Teacher
            {
                Name=teacher.Name,
                Profession=teacher.Profession,
                Photo=teacher.Photo
            };
            Skill skill = new Skill
            {
                Communication = teacher.Communication,
                Development = teacher.Development,
                Design = teacher.Design,
                Innovation = teacher.Innovation,
                Language = teacher.Language,
                TeamLeader = teacher.TeamLeader
            };
            TeacherInfo info = new TeacherInfo
            {
                Degree = teacher.Degree,
                Email = teacher.Email,
                Experience = teacher.Experience,
                Faculty = teacher.Faculty,
                Hobby = teacher.Hobby,
                Phone = teacher.Phone,
                Skype = teacher.Skype
            };
            if (teacher.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select a photo!");
                return View();
            }
            if (!teacher.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please, select correct file format!");
                return View(teacher);
            }
            if (teacher.Photo.Length(250))
            {
                ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                return View(teacher);
            }

            newTeacher.Image = await teacher.Photo.GetImagePath(_env.WebRootPath, @"img\teacher\");
            _db.Skills.Add(skill);
            _db.TeachersInfo.Add(info);
            newTeacher.SkillId = skill.Id;
            newTeacher.TeacherInfoId = info.Id;
            _db.Teachers.Add(newTeacher);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null) return NotFound();
            Teacher teacher = await _db.Teachers.Include(t=>t.Skill).Include(t => t.TeacherInfo).FirstOrDefaultAsync(c => c.Id == Id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? Id,Teacher teacher)
        {
            if (Id == null) return NotFound();
            Teacher teacherDb = await _db.Teachers.Include(t=>t.TeacherInfo).Include(t => t.Skill).
                            FirstOrDefaultAsync(c => c.Id == Id);
            if (teacherDb == null) return NotFound();
            teacherDb.TeacherInfo = teacher.TeacherInfo;
            teacherDb.Skill = teacher.Skill;
            teacherDb.Name = teacher.Name;
            teacherDb.Profession = teacher.Profession;

            if (teacher.Photo != null)
            {
                ModelState.AddModelError("Photo", "Please, select a photo!");
                if (!teacher.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please, select correct file format!");
                    return View(teacherDb);
                }
                if (teacher.Photo.Length(250))
                {
                    ModelState.AddModelError("Photo", "An image must not be 250 kb more than!");
                    return View(teacherDb);
                }
                Helper.DeleteImg(teacherDb.Image, _env.WebRootPath, @"img\teacher\");
                teacherDb.Image = await teacher.Photo.GetImagePath(_env.WebRootPath, @"img\teacher\");
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Teacher teacher = await _db.Teachers.Include(t => t.TeacherInfo).Include(t => t.Skill).FirstOrDefaultAsync(t=>t.Id==Id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? Id)
        {
            if (Id == null) return NotFound();
            Teacher teacher = await _db.Teachers.Include(t => t.TeacherInfo).Include(t => t.Skill).FirstOrDefaultAsync(t => t.Id == Id);
            if (teacher == null) return NotFound();
            Helper.DeleteImg(teacher.Image, _env.WebRootPath, @"img\teacher");
            _db.TeachersInfo.Remove(teacher.TeacherInfo);
            _db.Skills.Remove(teacher.Skill);
            _db.Teachers.Remove(teacher);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
