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
            if (security.GetLifeDate(token) != null)
                return new CityImplement().GetAllCityes();

            return null; // Иначе null
        }

        // Возвращаем один город по имени
        public City GetCity(string token, string name)
        {
            // Если токен найден, то выполни метод
            if (security.GetLifeDate(token) != null)
                return new CityImplement().GetCity(name);

            return null; // Иначе null
        }

        public bool AddCity(string token, string name)
        {
            // Если токен найден, то выполни метод
            if (security.GetLifeDate(token) != null)
                return new CityImplement().AddCity(name);

            return false; // Иначе null
        }

        #endregion



        // Конструктор сервиса
        public Service_A100()
        {
            Random rand = new Random();


            security = new SecurityManager(); // Выделяем память

            TimerCallback tm = new TimerCallback(security.DisposeToken); // Метод, который вызывается в таймере

            Timer timer = new Timer(tm, 0, 0, 5000); // Таймер вызывает метод каждые second

        }

        #region Секция Безопасности IUserService


        public string GetApiKey(string login, string password)
        {
            // Проверяем данные юзера в БД
            return security.AddToken(new Token(login, 30));
        }


        // Возвращаем дату жизни токена, если он найден
        public string GetLifeToken(string token)
        {
            return security.GetLifeDate(token);
        }



        SecurityManager security; // Менеджер, который отвечает за безопасность


        #endregion


    }
}
