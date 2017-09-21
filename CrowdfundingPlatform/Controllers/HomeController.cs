﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrowdfundingPlatform.Models;

namespace CrowdfundingPlatform.Controllers
{
    public class HomeController : Controller
    {
        PlatformDBContext db;
        public HomeController(PlatformDBContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
