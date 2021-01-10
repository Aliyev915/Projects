using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required]
        public string Description { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int BlogTypeId { get; set; }
        public string AppUserId { get; set; }
        public virtual BlogType BlogType { get; set; }
        public virtual ICollection<BlogTag> BlogTags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
