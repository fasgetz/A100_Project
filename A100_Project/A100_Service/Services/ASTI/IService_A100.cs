using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace A100_Service.Services.ASTI
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService_A100" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService_A100
    {
        [OperationContract]
        void SendMessage();


        [OperationContract]
        List<ASTI_DTO.City> GetCityes();

        [OperationContract]
        string GetString(string name);



    }
}
