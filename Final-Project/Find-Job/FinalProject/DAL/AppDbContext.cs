using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Candidate_Experience> Experiences { get; set; }
        public DbSet<Candidate_Education> Educations { get; set; }
        public DbSet<Candidate_Skill> Skills { get; set; }
        public DbSet<Demand> Demands { get; set; }
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<CompanyModerator> Moderators { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
    }
}
