﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class BarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}