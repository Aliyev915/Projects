using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(250)]
        public string Description { get; set; }
        [StringLength(1500)]
        public string About { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int TagId { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
