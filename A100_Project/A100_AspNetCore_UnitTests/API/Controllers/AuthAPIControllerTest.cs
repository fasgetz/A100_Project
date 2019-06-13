using A100_AspNetCore.API.Authentication.AuthenticationControllers;
using A100_AspNetCore.Models.Authentication;
using A100_AspNetCore.Services.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace A100_AspNetCore_UnitTests.API.Controllers
{

    /// <summary>
    /// Тест контроллера аутентификации
    /// </summary>

    public class AuthAPIControllerTest
    {


        IUserService service; // Сервис получения токенов
        AuthAPIController controller; // Контроллер
        //private Mock<UserManager<User>> _mockUserManager;
        //private Mock<SignInManager<User>> _mockSignInManager;

        //// Метод, который найден email a.radiukevich@technovik.ru
        //[Fact]
        //public async Task FindRadyukevichEmail()
        //{
        //    var mock = new Mock<IUserService>();
        //    mock.Setup(i => i.Authenticate(It.IsAny<string>(), It.IsAny<string>()));

        //    controller = new AuthAPIController(mock.Object);

        //    var token = controller.Token(new A100_AspNetCore.Models.API.AuthModel { login = "test", password = "test" });


        //    //
        //    var userStoreMock = new Mock<IUserStore<User>>();

        //    _mockUserManager = new Mock<UserManager<User>>(userStoreMock.Object,
        //        null, null, null, null, null, null, null, null);

        //    var contextAccessor = new Mock<IHttpContextAccessor>();
        //    var userPrincipalFactory = new Mock<IUserClaimsPrincipalFactory<User>>();

        //    _mockSignInManager = new Mock<SignInManager<User>>(_mockUserManager.Object,
        //        contextAccessor.Object, userPrincipalFactory.Object, null, null, null);


        //    UserService service = new UserService(_mockUserManager.Object, _mockSignInManager.Object);
         







        //    Assert.Equal(1, 1);
        //}
    }
}
