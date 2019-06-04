using A100_Service.Services.UserService.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.UserService
{
    [ServiceContract]
    public interface IUserService
    {
        // Метод, который получает API Key, если авторизация прошла успешно
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetApi?login={login}&pass={password}")]
        Token GetApiKey(string login, string password);

        // Метод возвращает дату, сколько осталось жить токену
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "GetDateLife?token={token}")]
        string GetLifeToken(string token);
    }
}
