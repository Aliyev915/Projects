using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public int Reply { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

    }
}
