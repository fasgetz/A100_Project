using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore_WEB.Models;

namespace AspNetCore_WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var client = new ServiceReference1.Service1Client();

            ViewBag.cities = client.GetCityesAsync().Result;

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
