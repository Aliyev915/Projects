using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;

namespace Project.ViewModels
{
    public class EventVM
    {
        public Event Event { get; set; }
        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public string  Speakers { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
