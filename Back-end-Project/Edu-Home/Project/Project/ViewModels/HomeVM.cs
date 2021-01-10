using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class HomeVM
    {
        public Setting Setting { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public Content Content { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public Imotional Imotional { get; set; }
        public IEnumerable<Notice> Notices { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
    }
}
