using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Services.API.CityService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.API.Controllers
{

    /// <summary>
    /// Контроллер городов
    /// </summary>



    [Route("api/[Controller]")]
    [Authorize]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityService service; // Сервис

        public CityController(ICityService service)
        {
            this.service = service;
        }

        #region Секция методов

        // GET Метод, который получает весь список городов
        [HttpGet]
        [Route("GetAllCities")]
        public async Task<List<City>> GetAllCities()
        {
            return await service.GetAllCityes();
        }

        // GET Метод, который получает город по имени
        [HttpGet]
        [Route("GetCityId")]
        public async Task<City> GetCityId([FromBody]City city)
        {
            return await service.GetCityId(city.CityId);
        }

        // GET Метод, который получает город по названию
        [HttpGet]
        [Route("GetCityName")]
        public async Task<City> GetCityName([FromBody]City city)
        {
            return await service.GetCityName(city.CityName);
        }

        // GET Метод, который добавляет город
        [HttpPost]
        [Authorize(Roles = "administrator")] // Роли для метода
        [Route("AddCity")]
        public async Task<City> AddCity([FromBody]City city)
        {            
            return await service.AddCity(city.CityName);
        }
        #endregion
    }
}
