using A100_Service.DataBase.ASTI;
using A100_Service.Services.ASTI.BusinessLogic;
using A100_Service.Services.ASTI.ServicesInterfaces;
using A100_Service.Services.UserService;
using A100_Service.Services.UserService.Security;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Threading;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service_A100" в коде и файле конфигурации.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service_A100 : IService_A100, ITypeCity, IUserService
    {
        
        #region Секция City

        // Возвращаем весь список городов
        public List<City> GetAllCityes(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return new CityImplement().GetAllCityes();
                
            return null; // Иначе null
        }

        // Возвращаем один город по имени
        public City GetCity(string token, string name)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return new CityImplement().GetCity(name);

            return null; // Иначе null
        }

        public bool AddCity(string token, string name)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return new CityImplement().AddCity(name);

            return false; // Иначе null
        }

        #endregion

        #region Конструктор

        //// Делегат, который принимает токен и возвращает true, если метод можно выполнить
        public delegate bool CanDo(string token);
        CanDo Check; // Переменная типа делегата, которая выполнит указанный на нее метод

        // Конструктор сервиса
        public Service_A100()
        {
            Random rand = new Random();

            // Выделяем память под защитника системы, который запрещает вызывать методы со стороны, если токен умер
            security = new SecurityManager();

            Check = CanEx; // Ссылаемся на метод            
        }

        private bool CanEx(string token)
        {
            // Если токен найден, то разреши выполнение метода
            if (security.GetTokenName(token) != null)
                return true;

            // Иначе, запрети
            return false;
        }


        #endregion

        #region Секция Безопасности IUserService

        // Менеджер, который отвечает за безопасность системы, т.к. запрещает использовать методы, если токена нет или он умер
        SecurityManager security;

        public string GetApiKey(string login, string password)
        {
            // Проверяем данные юзера в БД

            // Возвращаем токен
            return security.AddToken(login);
        }


        // Возвращаем дату жизни токена, если он найден
        public string GetLifeToken(string token)
        {
            return security.GetLifeDate(token);
        }

        #endregion


    }
  
}
