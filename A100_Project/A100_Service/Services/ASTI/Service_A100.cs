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
    public class Service_A100 : IService_A100, ITypeCity, IUserService, IProjects, IVik, IClients, IElements, IScheme, ISpecifications
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

        #region Секция Projects


        // Получаем список проектов пользователя
        public List<v_GetProjects> GetUserProjects(string token)
        {
            // Если токен найден, то верни список проектов пользователю
            return ProjectsLogic.GetUserProjects(security.GetTokenName(token).UserLogin);

        }


        // Метод, который получает информацию о проекте
        public v_GetWork GetWork(string token, int WarhouseID)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return ProjectsLogic.GetWork(WarhouseID);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить информацию о проекте"));
        }

        public List<Specifications> GetWarhouseKey(string token, string project)
        {
            throw new NotImplementedException();
        }

        public Control GetProjectData(string token, string project)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return ProjectsLogic.GetProjectData(project);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить информацию о проекте"));
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
            else
                return false;
        }


        #endregion

        #region Секция Безопасности IUserService

        // Менеджер, который отвечает за безопасность системы, т.к. запрещает использовать методы, если токена нет или он умер
        SecurityManager security;


        public Token GetApiKey(string login, string password)
        {
            // Делаем запрос в базу данных
            // Если пользователь найден, то верни токен
            var token = security.AddToken(login);

            // Если токен нашли, то возвращаем его
            if (token != null)
                return token;



            // Иначе выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить токен"), "Ошибка получения токена");
        }


        // Возвращаем дату жизни токена, если он найден
        public string GetLifeToken(string token)
        {
            return security.GetLifeDate(token);
        }

        public List<Specifications> GetProjectData(string project)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Секция VIK

        // Метод, который получает VIK проекта
        public List<v_GetVik> GetVik(string token, int ResoultID)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return VikLogic.GetVIK(ResoultID);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить информацию о VIK"));
        }

        // Получение названий VIK
        public List<VikElement> GetVikNames(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return VikLogic.GetVikNames();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить информацию о VIK"));
        }
        
        // Получение фотографий по айди Vik
        public List<byte[]> GetVIKPhotoList(string token, int idVik)
        {
            throw new NotImplementedException();
        }

        // Загрузка фотографии VIK на сервер
        public byte[] DownLoadVIKPhoto(string token, int rid, int idVik)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Секция Клиенты

        public List<Employee> GetEmployeesClients(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return ClientsLogic.GetEmployeesClients();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить клиентов"));
        }

        public List<ClientSchemePermissions> GetClientSchemePermissions(string token, string UserID, int ResoultID)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return ClientsLogic.GetClientSchemePermissions(UserID, ResoultID);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить клиентов"));
        }



        #endregion

        #region Секция элементов

        public List<Element> DictionaryElement(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return ElementLogic.GetElements();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить элементы"), "Невозможно получить элементы");
        }

        public List<ElementsOfType> GetElementsOfType(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return ElementLogic.GetElementsOfType();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Невозможно получить элементы"), "Невозможно получить элементы");
        }



        #endregion

        #region Секция схемы

        public List<v_GetMap> GetMap(string token, int ResoultID)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SchemeLogic.GetMap(ResoultID);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить схему"), "Не удалось загрузить схему");
        }

        public List<PartialTO> GetPartialTO(string token, int rid)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SchemeLogic.GetPartialTO(rid);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить схему"), "Не удалось загрузить схему");
        }

        #endregion

        #region Секция спецификации

        public List<Specifications> GetSpecifications(string token, int ResoultID)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SpecificationsLogic.GetSpecifications(ResoultID);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить спецификацию"), "Не удалось загрузить спецификацию");
        }


        List<v_GetSpecificationsElement> ISpecifications.GetSpecificationElement(string token, int ResoultID)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SpecificationsLogic.GetSpecificationsElement(ResoultID);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить спецификацию"), "Не удалось загрузить спецификацию");
        }

        List<Deviation> ISpecifications.GetDeviation(string token, int ResoultID)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SpecificationsLogic.GetDeviation(ResoultID);


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить спецификацию"), "Не удалось загрузить спецификацию");
        }

        List<DefectType> ISpecifications.GetDefectTypes(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SpecificationsLogic.GetDefectTypes();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить спецификацию"), "Не удалось загрузить спецификацию");
        }

        List<RiskLevel> ISpecifications.DictionaryRiskLevel(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SpecificationsLogic.DictionaryRiskLevel();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить спецификацию"), "Не удалось загрузить спецификацию");
        }

        List<ClientPermissions> ISpecifications.GetUserRoles(string token)
        {
            // Если токен найден, то выполни метод
            if (Check(token))
                return SpecificationsLogic.GetClientPermissions();


            // Иначе, выдай экзепшен
            throw new FaultException<MyException>(new MyException("Не удалось загрузить спецификацию"), "Не удалось загрузить спецификацию");
        }

        #endregion

    }

}

