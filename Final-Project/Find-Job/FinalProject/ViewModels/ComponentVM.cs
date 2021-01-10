using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class ComponentVM
    {
        public IEnumerable<Location> Locations { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
