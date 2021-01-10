using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Candidate_Experience
    {
        public int Id { get; set; }
        public string Speciality { get; set; }
        public string Company { get; set; }
        public string ExperienceYear { get; set; }
        public int CandidateId { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
