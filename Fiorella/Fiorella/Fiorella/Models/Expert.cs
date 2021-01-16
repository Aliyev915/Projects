using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Profession Profession { get; set; }
        public int ProfessionId { get; set; }
    }
}
