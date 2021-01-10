using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required,StringLength(250)]
        public string Logo { get; set; }
        [Required, StringLength(250)]
        public string BlackLogo { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Web { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
