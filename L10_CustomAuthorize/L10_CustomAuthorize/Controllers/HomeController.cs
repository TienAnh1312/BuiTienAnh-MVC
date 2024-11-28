﻿using L10_CustomAuthorize.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace L10_CustomAuthorize.Controllers
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
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.Email != "admin@gmail.com" && model.Password != "123456")
            {
                ModelState.AddModelError(String.Empty, "Tài Khoản Không Hợp Lệ");
                return View(model);
            }
            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.Email) }, "TAHello");
            var priciple = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync("TAHello", priciple);
            return RedirectToAction("Index", "Home");

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
