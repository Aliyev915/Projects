using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required,StringLength(100)]
        public string Profession { get; set; }
        public int SkillId { get; set; }
        public int TeacherInfoId { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }
    }
}
