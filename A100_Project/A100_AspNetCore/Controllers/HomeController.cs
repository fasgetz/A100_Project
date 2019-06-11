using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A100_AspNetCore.Models;
using A100_AspNetCore.Models.A100_Models.DataBase;
using Microsoft.EntityFrameworkCore;
using A100_AspNetCore.Services.API.CityService;

namespace A100_AspNetCore.Controllers
{
    public class HomeController : Controller
    {

        ICityService service;

        public HomeController(ICityService service)
        {
            this.service = service;
        }


        public async Task<IActionResult> Index()
        {
            return View(await new ASTIContext().ElementsOfType.ToListAsync());
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
