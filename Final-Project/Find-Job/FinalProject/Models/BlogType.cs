using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace FinalProject.Models
{
    public class BlogType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
