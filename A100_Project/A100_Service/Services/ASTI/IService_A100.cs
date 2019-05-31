using A100_Service.DataBase.ASTI;
using A100_Service.Services.ASTI.ServicesInterfaces;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace A100_Service.Services.ASTI
{

    /// <summary>
    /// Общий интерфейс сервиса, который представлен в REST архитектуре
    /// </summary>



    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService_A100" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService_A100
    {

        [OperationContract]
        void SendMessage();


        // POST - метод, который добавляет город
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "TestPOST", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        string Test();


        //[WebInvoke(Method = "POST", UriTemplate = "requests")]
        //[OperationContract]
        //void Save(string test);
    }


}
