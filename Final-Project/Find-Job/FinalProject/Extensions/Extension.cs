using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Extensions
{
    public static class Extension
    {
        public static async Task<string> CopyImage(this IFormFile file,string path,string folder)
        {
            string fileName = Guid.NewGuid() + file.FileName;
            string FullPath = Path.Combine(path, folder) + fileName;
            using (FileStream fileStream=new FileStream(FullPath,FileMode.Create))
            {
                 await file.CopyToAsync(fileStream);
            }
            return fileName;
        }

        public static IEnumerable<Job> Search(this IEnumerable<Job> jobs, AppDbContext _db, string text, string location, string category, 
                                    string type,string date, string experience, string salary)
        {
            Location loc = _db.Locations.FirstOrDefault(l => l.Name == location);
            Category cat = _db.Categories.FirstOrDefault(c => c.Name == category);
            Models.Type typ = _db.Types.FirstOrDefault(t => t.Name == type);
            #region Search
            if (text != null && typ != null)
            {
                if (cat != null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                Where(j => (j.LocationId == loc.Id) && (j.CategoryId == cat.Id) && (j.TypeId == typ.Id)).
                                                        Where(j => j.Name.Contains(text.Trim()));
                }
                else if (cat == null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                                        Where(j => j.LocationId == loc.Id && (j.TypeId == typ.Id)).
                                                        Where(j => j.Name.Contains(text.Trim()));
                }
                else if (loc == null && cat != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                                        Where(j => j.CategoryId == cat.Id && (j.TypeId == typ.Id)).
                                                        Where(j => j.Name.Contains(text.Trim()));
                }
                else
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j=>j.Type).
                                        Where(j => j.Name.Contains(text.Trim()) && (j.TypeId == typ.Id));
                }
            }
            else if (typ != null && text == null)
            {
                if (cat != null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).
                    Where(j => (j.LocationId == loc.Id) && (j.CategoryId == cat.Id) && (j.TypeId == typ.Id));
                }
                else if (cat == null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).
                                                        Where(j => (j.LocationId == loc.Id) && (j.TypeId == typ.Id));
                }
                else if (loc == null && cat != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).
                                                        Where(j => (j.CategoryId == cat.Id) && (j.TypeId == typ.Id));
                }
                else
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).
                                        Where(j => j.TypeId == typ.Id);
                }
            }
            else if (typ == null && text != null)
            {
                if (cat != null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                Where(j => (j.LocationId == loc.Id) && (j.CategoryId == cat.Id)).
                                Where(j => j.Name.Contains(text.Trim()));
                }
                else if (cat == null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                                        Where(j => j.LocationId == loc.Id).Where(j => j.Name.Contains(text.Trim()));
                }
                else if (loc == null && cat != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                                        Where(j => j.CategoryId == cat.Id).Where(j => j.Name.Contains(text.Trim()));
                }
                else
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).
                        Where(j => j.Name.Contains(text.Trim()));
                }
            }
            else
            {
                if (cat != null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                Where(j => (j.LocationId == loc.Id) && (j.CategoryId == cat.Id));
                }
                else if (cat == null && loc != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                                        Where(j => j.LocationId == loc.Id);
                }
                else if (loc == null && cat != null)
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).Include(j => j.Type).
                                                        Where(j => j.CategoryId == cat.Id);
                }
                else
                {
                    jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company);
                }
            }
            #endregion
            switch (date)
            {
                case "last-hour":
                    jobs = jobs.Where(j => j.Deadline >= DateTime.Now.AddHours(-1));
                    break;
                case "last-24-hour":
                    jobs = jobs.Where(j => j.Deadline >= DateTime.Now.AddHours(-24));
                    break;
                case "last-7-days":
                    jobs = jobs.Where(j => j.Deadline >= DateTime.Now.AddDays(-7));
                    break;
                case "last-30-days":
                    jobs = jobs.Where(j => j.Deadline >= DateTime.Now.AddDays(-30));
                    break;
            }
            if (experience != "All")
            {
                jobs = jobs.Where(j => j.Experience[0] >= experience[0] && j.Experience[2] <= experience[2]);
            }
            else if (experience == "More 5 Years")
            {
                jobs = jobs.Where(j => j.Experience[2] <= 5);
            }
            else
            {
                jobs = jobs.Where(j => j.Experience[0] >= 0);
            }
            if (salary == "All")
            {
                jobs = jobs.Where(j => j.Salary >= 0);
            }
            else if (salary.Trim() == "1000")
            {
                jobs = jobs.Where(j => j.Salary >= 1000);
            }
            else
            {
                string[] sal = salary.Split('-');
                jobs = jobs.Where(j => j.Salary >= int.Parse(sal[0]) && j.Salary <= int.Parse(sal[1]));
            }
            return jobs;
        }

    }
}
