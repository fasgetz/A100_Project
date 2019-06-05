using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Security.Cryptography;
using System.IO;
using EncriptionLibrary;

namespace ConsoleHost
{
    class Program
    {
        //public static byte[] DecodeUrlBase64(string s)
        //{
        //    s = s.Replace('-', '+').Replace('_', '/').PadRight(4 * ((s.Length + 3) / 4), '=');
        //    return Convert.FromBase64String(s);
        //}


        //readonly static string PasswordHash = "df^348eZ";
        //readonly static string SaltKey = "@l3#$kdZ";
        //readonly static string VIKey = "*d#kfFRkeWEoDpFe";

        //private static string Decrypt(string encryptedText)
        //{

        //    string input = encryptedText;
        //    byte[] buffer = Encoding.ASCII.GetBytes(input);
        //    string base64 = Convert.ToBase64String(buffer); // SGVsbG8sIFdvcmxk


        //    //byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
        //    byte[] cipherTextBytes = DecodeUrlBase64(base64);


        //    byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
        //    var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

        //    var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
        //    var memoryStream = new MemoryStream(cipherTextBytes);
        //    var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
        //    byte[] plainTextBytes = new byte[cipherTextBytes.Length];

        //    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
        //    memoryStream.Close();
        //    cryptoStream.Close();
        //    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        //}

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
