using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewModels
{
    public class ProductVM
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public IFormFile Photo { get; set; }
        public double Price { get; set; }
    }
}
