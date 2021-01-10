using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class BlogVM
    {
        public IEnumerable<Blog> All { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
        public string Message { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
