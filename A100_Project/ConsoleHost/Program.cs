using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Security.Cryptography;
using System.IO;

namespace ConsoleHost
{
    class Program
    {

        //readonly string PasswordHash = "df^348eZ";
        //readonly string SaltKey = "@l3#$kdZ";
        //readonly string VIKey = "*d#kfFRkeWEoDpFe";

        static void Main(string[] args)
        {
            //string PasswordHash = "df^348eZ";
            //string SaltKey = "@l3#$kdZ";
            //string VIKey = "*d#kfFRkeWEoDpFe";


            //string password = "test";



            //byte[] cipherTextBytes = Convert.FromBase64String(password);
            //byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            //var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            //var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            //var memoryStream = new MemoryStream(cipherTextBytes);
            //var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            //byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            //int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            //memoryStream.Close();
            //cryptoStream.Close();

            //Service.ASTIWSSoapClient a = new Service.ASTIWSSoapClient();





            //Console.WriteLine(a.GetEmpKey("test", "testtttt123S*"));






            //// Объявляем список, типа Row
            //List<Row> rowslist = new List<Row>()
            //{
            //    // Добавляем строки с разным текстом
            //    new Row("Первая строка, в который какой-то текст"),
            //    new Row("Вторая сторка"),
            //    new Row("Первая-Третья строка, в который какой-то текст лежит"),
            //    new Row("Строка"),
            //    new Row("Первая строка, в который какой-то текст"),
            //    new Row("Первая строка, в который какой-то текст"),
            //    new Row("Символы"),
            //    new Row("Текст"),
            //    new Row("Другая строка аываыв"),
            //    new Row("Мне уже лень придумывать, поэтому будет авыаффывпфывпждфывпжфыдвпждывпджыв"),
            //    new Row("ЫЫыывдывадывдаыдважфывпдфаыжвдпфждывдывждфжыдвыждфвд"),
            //};

            //// Перебираем элементы в коллекции, которые отсортированы
            //// в порядке возрастания по количеству символов в тексте
            //foreach (var item in rowslist.OrderBy(i => i.text.Count()))
            //{
            //    Console.WriteLine($"Количество символов {item.text.Count()}. Текст {item.text}");
            //}





            using (var host = new WebServiceHost(typeof(A100_Service.Services.ASTI.Service_A100)))
            {

                host.Open(); // Открываем хост

                Console.WriteLine("Хост открыт");

                Console.ReadKey(); // Заглушка
            }
        }
    }
}
