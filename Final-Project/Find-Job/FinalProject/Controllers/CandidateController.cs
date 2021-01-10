using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Controllers
{
    [Authorize]
    public class CandidateController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public CandidateController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public IActionResult Index(int? Id)
        {
            ViewBag.Candidates = _db.Candidates.Count();
            ViewBag.Page = Id;
            IEnumerable<Candidate> model;
            if (Id == null)
            {
                model = _db.Candidates.Include(j => j.Location).Include(c=>c.AppUser).OrderBy(j => j.Id).Take(4);
            }
            else
            {
                model = _db.Candidates.Include(j => j.Location).OrderBy(j => j.Id).Include(c=>c.AppUser).
                                Skip(4 * (int.Parse(Id.ToString()) - 1)).Take(4);
            }
            return View(model);
        }

        public async Task<IActionResult> Detail(string name)
        {
            if (name == null) return NotFound();
            Candidate candidate = await _db.Candidates.Include(c => c.Candidate_Skill).Include(c => c.Candidate_Education).
                                    Include(c => c.Candidate_Experience).Include(c => c.AppUser).
                                    Include(c => c.Location).FirstOrDefaultAsync(c => c.Fullname == name);
            if (candidate == null) return NotFound();
            int experience = 0;
            if (candidate.Candidate_Experience.FirstOrDefault().ExperienceYear != "none")
            {
                foreach (Candidate_Experience item in candidate.Candidate_Experience)
                {
                    string[] experiences = item.ExperienceYear.Split('-');
                    int difference = int.Parse(experiences[1]) - int.Parse(experiences[0]);
                    experience += difference;
                }

            }
            ViewBag.Experience = experience;
            return View(candidate);
        }

        public IActionResult Create()
        {
            ViewBag.Location = _db.Locations;
            ViewBag.Type = _db.Types;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CandidateVM candidate)
        {
            ViewBag.Type = _db.Types;
            Candidate_Education education = new Candidate_Education();
            Candidate_Experience experience = new Candidate_Experience();
            Location location = await _db.Locations.FirstOrDefaultAsync(l => l.Name == candidate.Location);
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            Candidate_Skill skill = new Candidate_Skill 
            {
                Speciality=candidate.Speciality,
                Community=candidate.Community,
                Language=candidate.Langugage,
                LeaderShip=candidate.LeaderShip,
            };
            await _db.Skills.AddAsync(skill);
            Candidate newCandidate = new Candidate
            {
                Fullname = candidate.Name + " " + candidate.Lastname,
                About = candidate.About,
                Profession = candidate.Profession,
                Image = user.Image,
                LocationId = location.Id,
                Candidate_SkillId = skill.Id,
                AppUserId=user.Id,
                Type=candidate.Type
            };
            await _db.Candidates.AddAsync(newCandidate);
            if (candidate.University != null)
            {

                education.EducationYear = candidate.EducationYear;
                education.School = candidate.University;
                education.Speciality = candidate.EduSpeciality;
                education.CandidateId = newCandidate.Id;
            }
            else
            {
                education.EducationYear = "none";
                education.School = "none";
                education.Speciality = "none";
                education.CandidateId = newCandidate.Id;
            }
            if (candidate.Company != null)
            {
                experience.Speciality = candidate.ExpSpeciality;
                experience.ExperienceYear = candidate.ExperienceYear;
                experience.Company = candidate.Company;
                experience.CandidateId = newCandidate.Id;
            }
            else
            {
                experience.Speciality = "none";
                experience.ExperienceYear = "none";
                experience.Company = "none";
                experience.CandidateId = newCandidate.Id;
            }
            await _db.Educations.AddAsync(education);
            await _db.Experiences.AddAsync(experience);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Sort(string sort)
        {
            IEnumerable<Candidate> candidates = _db.Candidates.Include(j=>j.AppUser).Include(j => j.Location).Take(4);
            ViewBag.Candidates = _db.Candidates.Count();
            if (sort == "old")
            {
                candidates = _db.Candidates.Include(j=>j.AppUser).Include(j => j.Location).OrderByDescending(c => c.Id).Take(4);
            }
            SearchVM model = new SearchVM
            {
                Candidates = candidates
            };
            return PartialView("_SearchPartial", model);
        }

    }
}