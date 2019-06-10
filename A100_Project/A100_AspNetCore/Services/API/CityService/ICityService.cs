using A100_AspNetCore.Models.A100_Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.CityService
{
    public interface ICityService
    {
        // GET - метод, который возвращает ВЕСЬ список городов
        Task<List<City>> GetAllCityes();

        // GET - метод, который получает город по имени
        Task<City> GetCityName(string name);

        // GET - метод, который получает город по айди
        Task<City> GetCityId(int id);


        // POST - метод, который добавляет город
        Task<City> AddCity(string name);


    }
}
