using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Project.DAL;

namespace Project.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Message  { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
