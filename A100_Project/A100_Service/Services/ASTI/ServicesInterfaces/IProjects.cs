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
    interface IProjects
    {
        // GET - метод, который возвращает список проектов пользователя
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetProjects?token={token}")]
        List<v_GetProjects> GetUserProjects(string token);

        // GET - метод, который получает информацию о проекте
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetWork?token={token}&id={WarhouseID}")]
        v_GetWork GetWork(string token, int WarhouseID);


        // GET - метод, который получает VIK по ResoultID
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetProjectVIK?token={token}&id={ResoultID}")]
        List<v_GetVik> GetVik(string token, int ResoultID);

    }
}
