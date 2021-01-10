using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        public string Time { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }
        [Required,StringLength(50)]
        public string Place { get; set; }
        public string About { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<EventSpeaker> EventSpeakers { get; set; }
        public virtual Category Category { get; set; }
    }
}
