using A100_AspNetCore.Services.API.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace A100_AspNetCore_UnitTests.API.Services
{
    /// <summary>
    /// Класс тестирует сервис проектов
    /// </summary>


    public class ProjectsServiceTest
    {

        IProjectsService service;

        // Arrange
        public ProjectsServiceTest()
        {
            service = new ProjectsService();
        }

        #region Trued-tested (Истинные тесты)

        // Тестовый метод, который получает информацию о проекте
        [Theory]
        [InlineData(9061)]
        [InlineData(9068)]
        [InlineData(9069)]
        [InlineData(9070)]
        public async void GetWorkTestTrue(int WarhouseID)
        {
            // Act
            var list = await service.GetWork(WarhouseID);


            // Assert
            Assert.NotNull(list);
        }


        // Метод, который возвращает список проектов пользователя
        [Theory]
        [InlineData("m.knyazeva@fm-craft.ru")]
        [InlineData("igor.modeev@rblogistics.ru")]
        [InlineData("mparikin@ozon.ru")]
        public async void GetUserProjectTestTrue(string name)
        {
            // Act
            var list = await service.GetUserProjects(name);

            // Assert
            Assert.NotNull(list);
        }


        // Метод, который возвращает информацию о проекте
        [Theory]
        [InlineData("1401-Э-18")]
        [InlineData("1492-Э-18")]
        [InlineData("1521-19")]
        public async void GetProjectDataTestTrue(string projectname)
        {
            // Act
            var project = await service.GetProjectData(projectname);

            // Assert
            Assert.NotNull(project);
        }

        #endregion

        #region Falsed-tested (Ложные тесты)


        // Тестовый метод, который получает информацию о проекте
        [Theory]
        [InlineData(9061444)]
        [InlineData(12032150)]
        [InlineData(339052355)]        
        public async void GetWorkTestFalse(int WarhouseID)
        {
            // Act
            var list = await service.GetWork(WarhouseID);


            // Assert
            Assert.Null(list);
        }

        // Метод, который возвращает информацию о проекте
        [Theory]
        [InlineData("Несуществующий проект")]
        [InlineData("Проект-проектный")]
        [InlineData("????ыыы")]
        public async void GetProjectDataTestFalse(string projectname)
        {
            // Act
            var project = await service.GetProjectData(projectname);

            // Assert
            Assert.Null(project);
        }

        // Метод, который возвращает список проектов пользователя
        [Theory]
        [InlineData("search")]
        [InlineData("Юзерныйюзер")]
        [InlineData("ozo@n.ru")]
        public async void GetUserProjectTestFalse(string name)
        {
            // Act
            var list = await service.GetUserProjects(name);


            // Assert
            Assert.Empty(list);
        }

        #endregion
    }
}
