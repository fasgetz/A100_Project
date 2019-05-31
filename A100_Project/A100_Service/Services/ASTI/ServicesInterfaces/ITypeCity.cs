using A100_Service.DataBase.ASTI;
using A100_Service.Services.ASTI.BusinessLogic;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace A100_Service.Services.ASTI.ServicesInterfaces
{

    /// <summary>
    /// Интерфейс предоставляет поведение категории City
    /// </summary>
    
    [ServiceContract]
    public interface ITypeCity
    {
        // GET - метод, который возвращает ВЕСЬ список городов
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllCityes")]
        List<City> GetAllCityes();

        // GET - метод, который возвращает один город по айди
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCity?name={name}")]
        City GetCity(string name);

        // POST - метод, который добавляет город
        [OperationContract]
        [WebInvoke(
            UriTemplate = "/AddCity",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, 
            Method = "POST")]
        string AddCity(City city);
    }
}
