﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required,StringLength(150)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
