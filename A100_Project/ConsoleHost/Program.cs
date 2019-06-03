using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new WebServiceHost(typeof(A100_Service.Services.ASTI.Service_A100)))
            {

                host.Open(); // Открываем хост

                Console.WriteLine("Хост открыт");

                Console.ReadKey(); // Заглушка
            }
        }
    }
}
