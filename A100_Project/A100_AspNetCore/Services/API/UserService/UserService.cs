using A100_AspNetCore.API.Authentication.Options;
using A100_AspNetCore.Models.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API
{

    /// <summary>
    /// Класс описывает логику работы сервиса авторизации API
    /// </summary>

    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        /// <summary>
        /// Конструктор, который принимает сервисы пользователей и авторизации
        /// </summary>
        /// <param name="userManager">Пользовательский сервис</param>
        /// <param name="signInManager">Авторизационный сервис</param>
        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;            
        }   


        
        /// <summary>
        /// Метод аутентификации, который возвращает JWT токен
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Authenticate(string username, string password)
        {
            // Ищем юзера
            var user = GetIdentity(username, password).Result;

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: user.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            // jwt = null;
            JwtSecurityTokenHandler s = new JwtSecurityTokenHandler();
           

            // Возвращаем токен
            return encodedJwt;
        }

        #region Вспомогательные методы



        /// <summary>
        /// Приватный, вспомогательный, метод, который ищет юзера по логину и паролю и возвращает привязку (В случае если юзер найден)
        /// </summary>
        /// <param name="username">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        /// <returns>Возвращает привязки пользователя</returns>
        private async Task<ClaimsIdentity> GetIdentity(string username, string password)
        {

            // Ищем пользователя по email
            User user = await _userManager.FindByEmailAsync(username);
            


            // Если пользователь не найден, верни ошибку о том, что такого юзера нет
            if (user == null)
                return null;




            //
            var t = GenerateRefreshToken();

            ClaimsPrincipal def;


            //



            // Проходим авторизацию (Если пользователь найден)
            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

            // Если авторизация не прошла успешно, то верни null
            if (!result.Succeeded)
                return null;

            // Далее, если авторизация успешная, то получи список ролей пользователя            
            var userRoles = await _userManager.GetRolesAsync(user);


            // Необходимо сделать привязки токена к пользователю
            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, username), // Логин к токену
                };

            // Добавляем список ролей
            foreach (var item in userRoles)
            {
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, item));
            }

            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity; // Возвращаем привязки
        }


        /// <summary>
        /// Метод генерирует refresh токен
        /// </summary>
        /// <returns>Возвращает сгенерированный refresh токен</returns>
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        #endregion



    }
}
