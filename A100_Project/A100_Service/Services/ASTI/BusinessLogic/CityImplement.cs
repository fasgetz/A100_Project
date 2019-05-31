using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using A100_Service.Services.ASTI.ServicesInterfaces;
using System;
using System.Collections.Generic;

namespace A100_Service.Services.ASTI.BusinessLogic
{

    /// <summary>
    /// Класс предоставляет реализацию интерфейса ICity CityImplement
    /// </summary>

    public class CityImplement : ITypeCity
    {
        // Метод, который возвращает ВЕСЬ список городов
        public List<City> GetAllCityes()
        {
            try
            {
                IRepository<City> db = new EFGenericRepository<City>(new DataBase.ASTI.ASTI()); // Создаем репозиторий для работы с БД

                return db.GetAllList(); // Возвращаем список городов
            }
            catch (Exception)
            {
                return null; // В случае ошибки, возвращаем null
            }
        }


        // Метод, который возвращает город по имени
        public City GetCity(string name)
        {
            try
            {
                IRepository<City> db = new EFGenericRepository<City>(new DataBase.ASTI.ASTI()); // Создаем репозиторий для работы с БД
               
                return db.FindQueryEntity(i => i.CityName == name); // Возвращаем город по имени
            }
            catch (Exception)
            {
                return null; // Если город не найден, то возвращаем null
            }
        }
    }
}
