﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Hoşgeldiniz";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string UserName, string Password)
        {
            ViewBag.Title = "Hoşgeldiniz";
            Authentication cslAuth = new Authentication();

            if (cslAuth.UsernamePasswordControl(UserName, Password))
            {
                ViewBag.Mesaj = "giriş başarılı";
                HttpContext.Session.SetString("UserSession", "1");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mesaj = cslAuth.ErrorMessage;
            }
            return View();
        }

    }
}
