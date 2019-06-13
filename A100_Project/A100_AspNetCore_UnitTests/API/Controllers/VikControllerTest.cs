using A100_AspNetCore.API.Controllers;
using A100_AspNetCore.Services.API.VikService;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace A100_AspNetCore_UnitTests.API.Controllers
{
    public class VikControllerTest
    {
        [Fact]
        public async void Test()
        {
            var mock = new Mock<IVikService>();


            var controller = new VIKController(mock.Object);

            var test = await controller.GetVikNames();


            Assert.NotNull(test);
        }
    }
}
