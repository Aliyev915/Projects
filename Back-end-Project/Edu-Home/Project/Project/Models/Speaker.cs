using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Profession { get; set; }
        public string Image { get; set; }
        public virtual ICollection<EventSpeaker> EventSpeakers { get; set; }

    }
}
