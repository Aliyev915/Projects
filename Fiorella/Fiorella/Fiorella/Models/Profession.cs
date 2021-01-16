using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Expert> Experts { get; set; }
        public virtual ICollection<Imotional> Imotionals { get; set; }
    }
}
