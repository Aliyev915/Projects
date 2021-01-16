using Fiorella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderContent Content { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Video Video { get; set; }
        public IEnumerable<VideoList> Lists { get; set; }
        public IEnumerable<Profession> Professions { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public IEnumerable<Imotional> Imotionals { get; set; }
        public IEnumerable<Carousel> Carousels { get; set; }
    }
}
