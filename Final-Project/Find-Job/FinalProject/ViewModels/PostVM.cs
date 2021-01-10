using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;

namespace FinalProject.ViewModels
{
    public class PostVM
    {
        [Required]
        public string Title { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string Currency { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string City { get; set; }
        public string Demand { get; set; }
        public int MinExperience { get; set; }
        public int MaxExperience { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        public Job Job { get; set; }
    }
}
