using A100_AspNetCore.Services.API.EmployeesService;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace A100_AspNetCore_UnitTests.API.Services
{

    /// <summary>
    /// Класс тестирует сервис проектов
    /// </summary>

    public class EmployeeServiceTest
    {
        private IEmployeeService service;


        public EmployeeServiceTest()
        {
            // Arrange
            service = new EmployeeService();
        }


        #region Истинные тесты

        // Метод, который получает список клиентов, имеющих доступ к приложению
        [Fact]
        public async void GetEmployeesClientsNotEmpty()
        {
            // Act
            var list = await service.GetEmployeesClients();

            // Assert
            Assert.NotEmpty(list);
        }


        #endregion
    }
}
