using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Fullname { get; set; }
        [Required, StringLength(50)]
        public string Profession { get; set; }
        [Required, StringLength(250)]
        public string Image { get; set; }
        public string About { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
        public int Candidate_SkillId { get; set; }
        public virtual Candidate_Skill Candidate_Skill { get; set; }
        public int LocationId { get; set; }
        public string AppUserId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Candidate_Education> Candidate_Education { get; set; }
        public virtual ICollection<Candidate_Experience> Candidate_Experience { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
