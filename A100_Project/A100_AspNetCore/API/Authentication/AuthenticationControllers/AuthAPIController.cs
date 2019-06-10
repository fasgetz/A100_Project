using A100_AspNetCore.Models.API;
using A100_AspNetCore.Services.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.API.Authentication.AuthenticationControllers
{

    /// <summary>
    /// Методы контроллера для аутентификации
    /// </summary>


    [Route("api/auth")]
    [Authorize]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private IUserService _userService;

        public AuthAPIController(IUserService userService)
        {
            _userService = userService;
        }



        // GET api/values
        [HttpPost]
        [Route("token")]
        [AllowAnonymous]
        public async Task Token([FromBody]AuthModel param)
        {
            var username = param.login;
            var password = param.password;

            var token = _userService.Authenticate(username, password);


            if (token == null)
            {
                Response.StatusCode = 400;
                await Response.WriteAsync("Invalid username or password.");

            }


            // Если авторизация прошла успешно, то формируем ответ
            var response = new
            {
                token = token,
                ExperesDate = DateTime.Now.AddDays(1)
            };

            // сериализация ответа
            Response.ContentType = "application/json";
            await Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented }));
        }


        // Тестовые методы ---------------------------


        // GET api/values
        [HttpGet]
        [Route("get")]
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values
        [HttpGet]
        [Route("GetRole")]
        [Authorize(Roles = "user")]
        public string GetRole()
        {
            return "Поздравляю, юзер!";
        }

        // GET api/values
        [HttpGet]
        [Route("GetAdmin")]
        [Authorize(Roles = "admin")]
        public string GetAdmin()
        {
            return "Поздравляю, админ!";
        }


        // GET api/values
        [HttpGet]
        [Route("test")]
        [AllowAnonymous]
        public IActionResult NeedTest()
        {
            dynamic kek = new ExpandoObject();
            kek.Name = "Andrew";
            kek.Age = 18;
            kek.deep = true;

            return Ok(kek);
        }

    }
}
