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
    interface IScheme
    {
        // GET - метод, который получает элементы схемы стеллажа
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetMap?token={token}&id={ResoultID}")]
        List<Specifications> GetMap(string token, int ResoultID);

        // GET - метод, который получает названия и типы уровней риска
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetPartialTO?token={token}&rid={rid}")]
        List<Specifications> GetPartialTO(string token, int rid);
    }
}
