using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Project.Models;

namespace Project.ViewModels
{
    public class CreateCourseVM
    {
        public int Id { get; set; }
        public IFormFile Photo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string Apply { get; set; }
        public string Certification { get; set; }
        public int Duration { get; set; }
        public int ClassDuration { get; set; }
        public string StartTime { get; set; }
        public double Fee { get; set; }
        public string Assestement { get; set; }
        public string SkillLevel { get; set; }
        public int Student { get; set; }
        public string Category { get; set; }
        public string Fullname { get; set; }
    }
}
