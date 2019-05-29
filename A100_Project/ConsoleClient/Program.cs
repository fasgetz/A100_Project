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


            using (var client = new ServiceReference1.Service1Client())
            {
                var kek = client.GetData(15);
                Console.WriteLine(kek);


                var list = client.GetCityes();
                foreach (var item in list)
                {
                    Console.WriteLine(item.CityName);
                }
            }

            Console.WriteLine("Конец");
            Console.ReadKey();
        }
    }
}
