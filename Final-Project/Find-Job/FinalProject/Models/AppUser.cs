using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class AppUser:IdentityUser
    {
        [Required,StringLength(50)]
        public string Fullname { get; set; }
        public bool IsDeleted { get; set; } = false;
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; } = false;
        [StringLength(250)]
        public string Phone { get; set; }
        public string Adress { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public ICollection<CompanyModerator> CompanyModerators { get; set; }
        public ICollection<Bookmark> Bookmarks { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
