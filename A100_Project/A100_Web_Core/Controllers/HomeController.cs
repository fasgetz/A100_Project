﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A100_Web_Core.Models;

namespace A100_Web_Core.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public JsonResult Getss()
        {
            dynamic kek = new System.Dynamic.ExpandoObject();
            kek.name = "Andrew";
            kek.age = 18;



            return Json(kek);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
