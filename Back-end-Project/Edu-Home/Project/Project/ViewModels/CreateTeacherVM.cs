﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class CreateTeacherVM
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public IFormFile Photo { get; set; }
        public int Communication { get; set; }
        public int Design { get; set; }
        public int Development { get; set; }
        public int Innovation { get; set; }
        public int Language { get; set; }
        public int TeamLeader { get; set; }
        public string Degree { get; set; }
        public string Email { get; set; }
        public string Experience { get; set; }
        public string Hobby { get; set; }
        public string Faculty { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
    }
}
