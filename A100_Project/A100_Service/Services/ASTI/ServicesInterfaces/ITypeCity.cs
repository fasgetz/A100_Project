using A100_Service.DataBase.ASTI;
using A100_Service.Services.ASTI.BusinessLogic;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllCityes?token={token}")]
        List<City> GetAllCityes(string token);

        // GET - метод, который возвращает один город по айди
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCity?token={token}&name={name}")]
        City GetCity(string token, string name);

        // POST - метод, который добавляет город и возвращает true / false (в случае успеха / неудачи)
        [OperationContract]
        [WebInvoke(
            UriTemplate = "/AddCity?token={token}&name={name}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST")]
        bool AddCity(string token, string name);
    }

}
