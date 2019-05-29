using A100_Service.DataBase.ASTI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace A100_Service.Services
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void SendMessage()
        {
            Console.WriteLine("Hello world!");
        }

        public List<ASTI_DTO.City> GetCityes()
        {
            using (ASTI db = new ASTI())
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
