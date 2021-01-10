using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class AboutVM
    {
        public Content Content { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public Bio Bio { get; set; }
        public Imotional Imotional { get; set; }
        public IEnumerable<Notice> Notices { get; set; }
        public IEnumerable<Setting> Settings { get; set; }
    }
}
