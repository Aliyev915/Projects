using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class AppUser:IdentityUser
    {
        public bool IsDeleted { get; set; } = false;
        public virtual ICollection<Shopping> Shoppings { get; set; }
    }
}
