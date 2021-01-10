
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,StringLength(150)]
        public string Name { get; set; }
        [Required,StringLength(100)]
        public string Icon { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
