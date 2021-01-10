using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class CourseVM
    {
        public Course Course { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseFeature> CourseFeatures { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
