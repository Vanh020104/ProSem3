﻿using Microsoft.AspNetCore.Mvc;

namespace ProSem3.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Details()

        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
