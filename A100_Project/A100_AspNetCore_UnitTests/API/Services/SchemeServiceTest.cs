using A100_AspNetCore.Services.API.SchemeService;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace A100_AspNetCore_UnitTests.API.Services
{

    /// <summary>
    /// Класс тестирует сервис Схем
    /// </summary>

    public class SchemeServiceTest
    {
        ISchemeService service;

        public SchemeServiceTest()
        {
            // Arrange
            service = new SchemeService();
        }

        #region Trued-tested

        // Метод, который получает названия и типы уровней риска
        [Theory]
        [InlineData(9057)]
        //[InlineData(10565)]
        //[InlineData(10563)]
        public async void GetPartialToNotNull(int ResoultId)
        {
            // Act
            var list = await service.GetPartialTO(ResoultId);

            // Assert
            Assert.NotEmpty(list);
        }


        // Метод, который получает элементы схемы стеллажа
        [Theory]
        [InlineData(10563)]
        [InlineData(10565)]
        [InlineData(10590)]
        public async void GetMapNotNull(int ResoultId)
        {
            // Act
            var list = await service.GetMap(ResoultId);

            // Assert
            Assert.NotEmpty(list);
        }

        // Метод, который получает соответствие типов стелажей и элементов
        [Fact]
        public async void GetElementsOfType()
        {
            // Act
            var list = await service.GetElementsOfType();


            // Assert
            Assert.NotEmpty(list);
        }


        // Метод, который получает названия элементов стелажа Element
        [Fact]
        public async void DictionaryElementNotNull()
        {
            // Act
            var list = await service.DictionaryElement();

            // Assert
            Assert.NotEmpty(list);
        }

        // Метод, который получает зоны ответственности клиентов на складе
        [Theory]
        [InlineData("8ee3fd0c-6b10-421e-932c-d74f8b8deadf", 5020)]
        [InlineData("9090ace6-9b1b-4f34-9364-9f6cafdfec35", 9057)]
        [InlineData("3e634ed4-3a38-493e-b6dc-c71cc27545ee", 9057)]
        public async void GetClientSchemePermissionsTrue(string IdUser, int resoultid)
        {
            // Act
            var list = await service.GetClientSchemePermissions(IdUser, resoultid);


            // Assert
            Assert.NotEmpty(list);
        }

        #endregion


        #region Falsed-tested

        // Метод, который получает названия и типы уровней риска
        [Theory]
        [InlineData(10565)]
        [InlineData(10563)]
        public async void GetPartialToNull(int ResoultId)
        {
            // Act
            var list = await service.GetPartialTO(ResoultId);

            // Assert
            Assert.Empty(list);
        }

        // Метод, который получает элементы схемы стеллажа
        [Theory]
        [InlineData(1450563)]
        [InlineData(164370565)]
        [InlineData(15470590)]
        public async void GetMapNulled(int ResoultId)
        {
            // Act
            var list = await service.GetMap(ResoultId);

            // Assert
            Assert.Empty(list);
        }

        // Метод, который получает зоны ответственности клиентов на складе
        [Theory]
        [InlineData("dsgsadgasdg", 502340)]
        [InlineData("9aasd5", 90547)]
        [InlineData("8ee3fd0cgsda-932ertrtb8deadf", 9043657)]
        public async void GetClientSchemePermissionsFalse(string IdUser, int resoultid)
        {
            // Act
            var list = await service.GetClientSchemePermissions(IdUser, resoultid);


            // Assert
            Assert.Empty(list);
        }

        #endregion
    }
}
