using A100_AspNetCore.API.Authentication.AuthenticationControllers;
using A100_AspNetCore.API.Controllers;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.API;
using A100_AspNetCore.Models.Authentication;
using A100_AspNetCore.Services.API;
using A100_AspNetCore.Services.API.VikService;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace A100_AspNetCore_UnitTests.API.Services
{

    /// <summary>
    /// Класс, который проверяет работоспособность сервиса VIK
    /// </summary>


    public class VikServiceTest
    {

        private IVikService service; // Сервис VIK


        // Объявления в конструкторе
        public VikServiceTest()
        {
            // Arrange

            var services = new ServiceCollection();
            services.AddTransient<IVikService, VikService>();

            var serviceProvider = services.BuildServiceProvider();

            service = serviceProvider.GetService<IVikService>();
        }


        [Fact]
        public async void TestedGetVikNamesMethod()
        {
            // Act
            var test = await service.GetVikNames();



            // Assert

            Assert.IsType<List<VikElement>>(test);

            Assert.NotNull(test); // Проверяем, что не пустой

            // Проверяем количество, чтобы было 19 элементов (можно убрать, если будет дополняться)
            Assert.Equal(19, test.Count); 
        }



        // Тестовый метод, который получает VIK по ResoultID
        [Theory]
        [InlineData(11998)]
        [InlineData(9057)]
        public async void GetVikByResoultID(int ResoultID)
        {
            // Act
            var test = await service.GetVik(ResoultID); // получаем VIK


            // Assert
            Assert.NotNull(test); // Проверяем, что не пустой и объекты получены            

        }


    }
}
