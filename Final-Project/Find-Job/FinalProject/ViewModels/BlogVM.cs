using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Http;

namespace FinalProject.ViewModels
{
    public class BlogVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Type { get; set; }
        public string[] Tags { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
