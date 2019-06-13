using A100_AspNetCore.API.Controllers;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Services.API.CityService;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace A100_AspNetCore_UnitTests.API.Services
{

    /// <summary>
    /// Класс, который проверяет работоспособность сервиса City
    /// </summary>

    public class CityServiceTest
    {
        private ICityService service; // Сервис VIK

        // Объявления в конструкторе
        public CityServiceTest()
        {
            // Arrange

            service = new CityService();
        }

        // Тестовый метод, который получает города, переданные в параметрах
        [Theory]
        [InlineData("Москва")]
        [InlineData("Владимир")]
        [InlineData("Тула")]
        [InlineData("Калуга")]
        [InlineData("Балашиха")]
        public async void GetCityName(string name)
        {
            var city = await service.GetCityName(name);
            
            Assert.NotNull(city); // Проверяем, получин ли объект
            Assert.Equal(name, city.CityName); // Проверяем на соответствие
        }


        // Тестовый метод, который получает весь список городов
        [Fact]
        public async void GetAllCities()
        {
            var list = await service.GetAllCityes();

            Assert.NotNull(list); // Проверяем список на пустоту (Если не пустой, то города получены)
        }


        // Тестовый метод, который не получит не существующий город
        [Theory]
        [InlineData("Какой-то там город")]
        [InlineData("Владик")]
        [InlineData("Масква")]
        [InlineData("Moscow")]
        [InlineData("Царь-Град")]
        public async void GetFailedCityName(string name)
        {
            var city = await service.GetCityName(name);

            Assert.Null(city);
        }

        // Метод, который получает город по айди (успешный)
        [Theory]
        [InlineData(1)]
        [InlineData(3053)]
        [InlineData(6)]
        [InlineData(1009)]
        [InlineData(8)]
        public async void GetCityIdTrue(int id)
        {
            var city = await service.GetCityId(id);

            Assert.NotNull(city);
        }

        // Получение городов по айди, которых не существует
        [Theory]
        [InlineData(155)]
        [InlineData(30532)]
        [InlineData(65532)]
        [InlineData(3241009)]
        [InlineData(423428)]
        public async void GetCityIdFalse(int id)
        {
            var city = await service.GetCityId(id);

            Assert.Null(city);
        }




        //// Тестовый метод контроллера с созданием фейкового объекта
        //[Fact]
        //public async Task tested()
        //{
        //    var mock = new Mock<ICityService>();
        //    mock.Setup(i => i.GetCityName(It.IsAny<string>())).ReturnsAsync(new City { CityName = "Moscow" });

        //    var controller = new CityController(mock.Object);

        //    var result = await controller.GetCityName(new City { CityName = "Тест"});


        //    Assert.NotNull(result);

        //}



    }
}
