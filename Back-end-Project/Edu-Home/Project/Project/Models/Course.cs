using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
        public int CourseFeaturesId { get; set; }
        public int CategoryId { get; set; }
        public string AppUserId { get; set; }
        public virtual CourseFeature CourseFeatures { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual Category Category { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
