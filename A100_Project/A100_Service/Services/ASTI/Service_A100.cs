using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace A100_Service.Services.ASTI
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service_A100" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service_A100 : IService_A100
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello world!");
        }

        public string GetCityesJson()
        {
            Console.WriteLine("Возвращаем города");

            try
            {
                IRepository<City> db = new EFGenericRepository<City>(new DataBase.ASTI.ASTI());

                var list = db.GetAllList();

                var nes = from b in list
                          select new ASTI_DTO.City()
                          {
                              CityID = b.CityID,
                              CityName = b.CityName
                          };

                string json = JsonLibrary.JsonFunctional.GetJson(nes);




                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<List<City>, List<ASTI_DTO.City>>();
                });
                IMapper mapper = config.CreateMapper();
                

                


                return json;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
            
        }

        public string GetString(string name)
        {


            

            return name;
        }
    }
}
