using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Category
    {
        public int Id  { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
