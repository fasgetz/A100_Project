using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using A100_Service.Exceptions;
using A100_Service.Services.ASTI.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace A100_Service.Services.ASTI.BusinessLogic
{

    /// <summary>
    /// Класс предоставляет реализацию интерфейса ICity CityImplement
    /// </summary>

    public static class CityImplement
    {


        // Метод, который возвращает ВЕСЬ список городов
        public static List<City> GetAllCityes()
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
        public static City GetCity(string name)
        {
            try
            {
                IRepository<City> db = new EFGenericRepository<City>(new DataBase.ASTI.ASTI()); // Создаем репозиторий для работы с БД
               
                return db.FindQueryEntity(i => i.CityName == name); // Возвращаем город по имени
            }
            catch (Exception)
            {
                // Обработать какую-нибудь ошибку
                return null;
            }
        }


        // Метод, который добавляет город
        public static bool AddCity(string name)
        {

            try
            {
                if (name != null && name != string.Empty)
                {
                    IRepository<City> db = new EFGenericRepository<City>(new DataBase.ASTI.ASTI()); // Создаем репозиторий для работы с БД
                    db.Add(new City() { CityName = name }); // Добавляем город в БД
                    return true; // т.к. город успешно добавлен
                }

            }
            catch (Exception)
            {
                // Обработать какую-нибудь ошибку
            }

            return false; // т.к. возникла какая либо ошибка при добавлении города
        }
    }
}
