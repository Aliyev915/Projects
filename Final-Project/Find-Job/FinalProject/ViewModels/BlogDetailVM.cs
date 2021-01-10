using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class BlogDetailVM
    {
        public Blog Blog { get; set; }
        public string Message { get; set; }
        public int? Reply { get; set; }
    }
}
