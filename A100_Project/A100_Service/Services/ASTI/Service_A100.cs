using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace A100_Service.Services.ASTI
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service_A100" в коде и файле конфигурации.
    public class Service_A100 : IService_A100
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello world!");
        }

        public List<ASTI_DTO.City> GetCityes()
        {
            using (DataBase.ASTI.ASTI db = new DataBase.ASTI.ASTI())
            {
                var list = db.City.ToList();

                var nes = from b in list
                          select new ASTI_DTO.City()
                          {
                              CityID = b.CityID,
                              CityName = b.CityName
                          };


                return nes.ToList();
            }
        }
    }
}
