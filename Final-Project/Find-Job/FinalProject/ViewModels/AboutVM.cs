using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class AboutVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Statistic> Statistics { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Company> Companies { get; set; }
    }
}
