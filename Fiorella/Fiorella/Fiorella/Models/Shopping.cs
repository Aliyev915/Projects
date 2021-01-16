using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class Shopping
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int Count { get; set; }
        public double Total { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
    }
}
