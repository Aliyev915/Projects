using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Candidate_Education
    {
        public int Id { get; set; }
        [Required]
        public string Speciality { get; set; }
        [Required,StringLength(100)]
        public string School { get; set; }
        [Required]
        public string EducationYear { get; set; }
        public virtual Candidate Candidate { get; set; }
        public int CandidateId { get; set; }
    }
}
