using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class MessageVM
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public Job Job { get; set; }
        public Bio Bio { get; set; }
    }
}
