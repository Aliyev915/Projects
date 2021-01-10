﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Bio> Bio { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Imotional> Imotional { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TeacherInfo> TeachersInfo { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<EventSpeaker> EventSpeakers  { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Reply> Replies{ get; set; }
    }
}
