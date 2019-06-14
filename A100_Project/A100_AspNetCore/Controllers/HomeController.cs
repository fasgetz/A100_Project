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
using Microsoft.AspNetCore.Http;

namespace A100_AspNetCore.Controllers
{
    public class HomeController : Controller
    {

        ICityService service;
        private readonly IHttpContextAccessor _httpContextAcessor;

        public HomeController(ICityService service, IHttpContextAccessor tp)
        {
            this.service = service;
            _httpContextAcessor = tp;
        }

        const string SessionKeyName = "_Name";
        const string SessionKeyYearsMember = "_YearsMember";
        const string SessionKeyDate = "_Date";

        [HttpGet]
        public string Get()
        {
            var name = HttpContext.Session.GetString(SessionKeyName);
            var yearsMember = _httpContextAcessor.HttpContext.Session.GetInt32(SessionKeyYearsMember);

            return $"Name: \"{name}\",  Membership years: \"{yearsMember}\"";
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
