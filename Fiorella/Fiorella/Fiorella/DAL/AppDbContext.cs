using Fiorella.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoList> Lists { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Imotional> Imotionals { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Shopping> Shoppings { get; set; }
    }
}
