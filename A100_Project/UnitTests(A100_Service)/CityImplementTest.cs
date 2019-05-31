using A100_Service.DataBase.ASTI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace UnitTests_A100_Service_
{

    /// <summary>
    /// Класс тестирует бизнес-логику CityImplement
    /// </summary>


    [TestFixture]     
    class CityImplementTest
    {

        // Метод, который должен получить город Москву
        [Test]
        public async void GetCityMoscow()
        {
            string response = null;

            using (var client = new HttpClient())
            {
                var uri = new Uri("http://localhost:9000/City/GetCity?name=Москва");
                response = await client.GetStringAsync(uri);


            }

            City city = JsonLibrary.JsonFunctional.GetObjects<City>(response);

            Assert.AreEqual("Москва", city.CityName);
        }
    }
}
