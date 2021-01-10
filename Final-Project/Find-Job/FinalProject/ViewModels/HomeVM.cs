using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;

namespace FinalProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<Location> Locations { get; set; }
        public IEnumerable<Statistic> Statistics { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public string Search { get; set; }
        public string Location { get; set; }
    }
}
