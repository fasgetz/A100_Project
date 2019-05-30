using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Начало");

            using (var client = new Service.Service_A100Client())
            {
                client.SendMessage();


                Console.WriteLine(client.GetString("hello world!"));
                
                var list = client.GetCityes();

                foreach (var item in client.GetCityesAsync().Result)
                {
                    Console.WriteLine(item.CityName);
                }


                string json = JsonLibrary.JsonFunctional.GetJson(list);

                Console.WriteLine(json);

                List<ASTI_DTO.City> kek = JsonLibrary.JsonFunctional.GetObjects<List<ASTI_DTO.City>>(json);

                Console.WriteLine(kek.Count().ToString());
                
                

            }




            Console.WriteLine("Конец");
            Console.ReadKey();
        }

        
    }
}
