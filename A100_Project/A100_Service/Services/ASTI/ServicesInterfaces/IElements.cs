using A100_Service.DataBase.ASTI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI.ServicesInterfaces
{
    [ServiceContract]
    interface IElements
    {
        // GET - метод, который получает названия элементов стелажа Element
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetElementNames?token={token}")]
        List<Specifications> GetElementNames(string token);

        // GET - метод, который получает соответствие типов стелажей и элементов
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetElementsOfType?token={token}")]
        List<Specifications> GetElementsOfType(string token);
    }
}
