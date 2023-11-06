﻿using ASP.NET___Fixed_Version.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace ASP.NET___Fixed_Version.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }

        public IActionResult About(Operator op)
        {
            ViewBag.Op = op;
            return View();
        }
        public IActionResult Calculator()
        {
            string op = Request.Query["op"];
            ViewBag.op = op;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}