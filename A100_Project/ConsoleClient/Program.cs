using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{


    public class Book
    {
        public string name { get; set; }

        public Book(string name)
        {
            this.name = name;
        }
    }


    public class Library
    {
        private Book[] books;

        public Library(Book[] books)
        {
            this.books = books;
        }

        public int Lenght
        {
            get => books.Length;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < books.Length; i++)
            {
                yield return books[i].name;
            }
        }
    }


    class Program
    {


        static void Main(string[] args)
        {

            Book[] books = new Book[4];

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book($"Книга {i + 1}");
            }



            Library lib = new Library(books);

            foreach (var item in lib)
            {
                Console.WriteLine(item);
            }
            


           
            //Console.WriteLine("Начало");


            ////Task.Run(() => GetResult());

            ////using (var client = new Service.Service_A100Client())
            ////{
            ////    client.SendMessage();
            ////    Console.WriteLine(client.GetString("hello world!"));
            ////    var list = JsonLibrary.JsonFunctional.GetObjects<List<ASTI_DTO.City>>(client.GetCityesJson());
            ////    foreach (var item in list)
            ////    {
            ////        Console.WriteLine(item.CityName);
            ////    }
            ////    //var list = client.GetCityes();
            ////}

            //Console.WriteLine("Конец");
            //Console.ReadKey();
        }

        private static async Task GetResult()
        {
            string response = null;

            using (var client = new HttpClient())
            {
                var uri = new Uri("http://localhost:9000/City/GetAllCityes");
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
