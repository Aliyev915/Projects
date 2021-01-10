using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class AppUser : IdentityUser
    {
        [Required, StringLength(50)]
        public string Fullname { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsSubscribed { get; set; } = false;

    }
}
