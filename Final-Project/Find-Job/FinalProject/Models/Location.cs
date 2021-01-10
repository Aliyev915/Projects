using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}
