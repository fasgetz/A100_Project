using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {


        static void Main(string[] args)
        {



            
            
            Console.WriteLine("Начало");


            Task.Run(() => GetResult());

            //using (var client = new Service.Service_A100Client())
            //{
            //    client.SendMessage();
            //    Console.WriteLine(client.GetString("hello world!"));
            //    var list = JsonLibrary.JsonFunctional.GetObjects<List<ASTI_DTO.City>>(client.GetCityesJson());
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item.CityName);
            //    }
            //    //var list = client.GetCityes();
            //}

            Console.WriteLine("Конец");
            Console.ReadKey();
        }

        private static async Task GetResult()
        {
            string response = null;

            using (var client = new HttpClient())
            {
                var uri = new Uri("http://localhost:9000/GetCityes");
                response = await client.GetStringAsync(uri);

                try
                {
                    List<ASTI_DTO.City> list = JsonLibrary.JsonFunctional.GetObjects<List<ASTI_DTO.City>>(response);


                    foreach (var item in list)
                    {
                        Console.WriteLine(item.CityName);
                    }
                    //var list = JsonConvert.DeserializeObject<dynamic>(response).GetCityesResult;


                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item.CityName);
                    //}

                    //Console.WriteLine(JsonLibrary.JsonFunctional.GetJson(list));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



                Console.WriteLine(response);
            }

            

        }


    }
}
