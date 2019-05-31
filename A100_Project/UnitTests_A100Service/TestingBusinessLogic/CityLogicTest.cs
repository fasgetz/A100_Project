using A100_Service.DataBase.ASTI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using JsonLibrary;

namespace UnitTests_A100Service.TestingBusinessLogic
{

    /// <summary>
    /// Класс предоставляет тесты бизнес-логики обмена данными в категории City
    /// </summary>

    [TestFixture]
    class CityLogicTest
    {

        #region Секция метода GetCity, который получает город по имени

        // Метод должен получить москву
        [Test]
        public async Task GetMoscow()
        {

            using (var client = new HttpClient())
            {
                // Arrange
                var uri = new Uri("http://localhost:9000/City/GetCity?name=Москва"); // Адрес 
                City CityEXP = new City() { CityName = "Москва" }; // Что получаем

                // Act
                string response = await client.GetStringAsync(uri); // Получаем в JSON
                City CityAct = JsonLibrary.JsonFunctional.GetObjects<City>(response);
                
                // Assert
                Assert.IsNotNull(response); // Проверяем, получили ли Json
                Assert.AreEqual(CityEXP.CityName, CityAct.CityName); // Проверяем соответствие на эквивалентность

            }
           
        }




        #endregion


    }
}
