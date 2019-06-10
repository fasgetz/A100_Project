using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A100_AspNetCore.Models;
using A100_AspNetCore.Models.A100_Models.DataBase;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Controllers
{
    public class HomeController : Controller
    {

        private ASTIContext db;


        public HomeController(ASTIContext context)
        {
            db = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await db.City.ToListAsync());
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
