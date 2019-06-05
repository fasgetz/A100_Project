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
    interface IClients
    {
        // GET - метод, который получает список клиентов, имеющих доступ в приложение
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetEmployeesClients?token={token}")]
        List<Employee> GetEmployeesClients(string token);

        // GET - метод, который получает зоны ответственности клиентов на складе
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetClientSchemePermissions?token={token}&uid={UserID}&rid={ResoultID}")]
        List<ClientSchemePermissions> GetClientSchemePermissions(string token, string UserID, int ResoultID);
    }
}
