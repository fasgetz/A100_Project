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

            using (var client = new ASTI_Service.ASTI_ServicesClient())
            {

                var list = client.GetCityes();
                foreach (var item in list)
                {
                    Console.WriteLine(item.CityName);
                }
            }


 
            Console.WriteLine("Конец");
            Console.ReadKey();
        }

        private static async void WriteCityes()
        {

            await Task.Run(() =>
            {
                using (var client = new ASTI_Service.ASTI_ServicesClient())
                {
                    var list = client.GetCityes();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.CityName);
                    }

                }
            });
            
        }
    }
}
