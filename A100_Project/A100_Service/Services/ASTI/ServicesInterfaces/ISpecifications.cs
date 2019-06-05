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
    interface ISpecifications
    {
        // GET - метод, который получает спецификации (типы стелажей) по ResoultID
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetSpecifications?token={token}&id={ResoultID}")]
        List<Specifications> GetSpecifications(string token, int ResoultID);

        // GET - метод, который получает элементы стеллажей по ResoultID
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetSpecificationElement?token={token}&id={ResoultID}")]
        List<Specifications> GetSpecificationElement(string token, int ResoultID);

        // GET - метод, который получает спецификации (типы стелажей) по ResoultID
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetDeviation?token={token}&id={ResoultID}")]
        List<Specifications> GetDeviation(string token, int ResoultID);

        // GET - метод, который получает типы дефектов
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetDefectTypes?token={token}")]
        List<Specifications> GetDefectTypes(string token);

        // GET - метод, который получает названия и типы уровней риска
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "DictionaryRiskLevel?token={token}")]
        List<Specifications> DictionaryRiskLevel(string token);

        // GET - метод, который получает названия и типы уровней риска
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetUserRoles?token={token}")]
        List<Specifications> GetUserRoles(string token);
    }
}
