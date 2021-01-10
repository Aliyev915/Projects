using Microsoft.AspNetCore.Http;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class CreateEventVM
    {
        [Required,StringLength(100)]
        public string EventName { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        public string About { get; set; }
        [Required,StringLength(50)]
        public string Place { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Time { get; set; }
        public string Category { get; set; }
        public string Speaker{ get; set; }
        public string Fullname { get; set; }
    }
}
