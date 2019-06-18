using A100_AspNetCore.Models.API;
using A100_AspNetCore.Services.API;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.API.Authentication.AuthenticationControllers
{

    /// <summary>
    /// Методы контроллера для аутентификации
    /// </summary>


    [Route("api/auth")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAcessor;
        private readonly CounterMiddleWare md;

        public AuthAPIController(IUserService userService, IHttpContextAccessor tp, CounterMiddleWare md)
        {
            _userService = userService;
            _httpContextAcessor = tp;
            this.md = md;
        }



        // GET api/values
        [HttpPost]
        [Route("token")]
        [AllowAnonymous]
        public async Task<IActionResult> Token([FromBody]AuthModel param)
        {

            if (param == null)
                return BadRequest("Пользователь не установлен");


            var token = _userService.Authenticate(param.login, param.password);


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
            //Response.ContentType = "application/json";
            //await Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented }));
            return Ok(response);
        }


        // Тестовые методы ---------------------------


        // GET api/values
        [HttpGet]
        [AllowAnonymous]
        [Route("get")]
        public string Get()
        {
            md.min();
            return "Гет метод что-то возвращает";
            //return "tested!";

            //return new string[] { "value1", "value2" };
        }

        // GET api/getrole
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
        [Authorize(Roles = "administrator")]
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
