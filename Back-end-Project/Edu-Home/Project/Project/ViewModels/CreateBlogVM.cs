using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class CreateBlogVM
    {
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        public string About { get; set; }
        public string Author { get; set; }
        public DateTime Time { get; set; }
        public string Category { get; set; }
        public string Tag { get; set; }
    }
}
