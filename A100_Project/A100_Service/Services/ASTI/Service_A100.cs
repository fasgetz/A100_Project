using A100_Service.DataBase.aspASTI;
using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using A100_Service.Exceptions;
using A100_Service.Services.ASTI.BusinessLogic;
using A100_Service.Services.ASTI.ServicesInterfaces;
using A100_Service.Services.UserService;
using A100_Service.Services.UserService.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
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
                return CityImplement.GetAllCityes();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить города"));
        }

        // Возвращаем один город по имени
        public City GetCity(string token, string name)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return CityImplement.GetCity(name);

            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить город"));
        }

        public bool AddCity(string token, string name)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return CityImplement.AddCity(name);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Город невозможно добавить"));
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

            throw new FaultException<MyException>(new MyException("Вам отказано в доступе"),
                new FaultReason("Вам отказано в доступе"));
        }


        #endregion

        #region Секция Безопасности IUserService

        // Менеджер, который отвечает за безопасность системы, т.к. запрещает использовать методы, если токена нет или он умер
        SecurityManager security;


        public Token GetApiKey(string login, string password)
        {
            // Делаем запрос в базу данных
            // Если пользователь найден, то верни токен
            if (new EFGenericRepository<AspNetUsers>(new aspASTI()).FindQueryEntity(i => i.Email == login && i.PasswordHash == password) != null)
                return security.AddToken(login);


            // Иначе выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить города"));
        }

        // Возвращаем дату жизни токена, если он найден
        public string GetLifeToken(string token)
        {
            return security.GetLifeDate(token);
        }

        #endregion

    }

}

