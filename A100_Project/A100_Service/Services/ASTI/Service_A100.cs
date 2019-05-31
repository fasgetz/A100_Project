using A100_Service.DataBase.ASTI;
using A100_Service.Services.ASTI.BusinessLogic;
using A100_Service.Services.ASTI.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace A100_Service.Services.ASTI
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service_A100" в коде и файле конфигурации.
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service_A100 : IService_A100, ITypeCity
    {
        
        #region Секция City

        // Возвращаем весь список городов
        public List<City> GetAllCityes()
        {
            return new CityImplement().GetAllCityes();
        }

        // Возвращаем один город по имени
        public City GetCity(string name)
        {
            return new CityImplement().GetCity(name);
        }

        public string AddCity(City city)
        {
            return new CityImplement().AddCity(city);
        }

        #endregion

        public void SendMessage()
        {
            throw new NotImplementedException();
        }

        public string Test()
        {
            return "POST!!!!";
        }
    }
}
