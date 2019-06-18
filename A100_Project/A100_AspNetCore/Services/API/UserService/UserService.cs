using A100_AspNetCore.API.Authentication.Options;
using A100_AspNetCore.Models.Authentication;
using A100_AspNetCore.Services.API.RefreshTokenService;
using A100_AspNetCore.Services.API.RefreshTokenService.Models;
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
        private readonly TokensService tokensService; // Сервис токенов

        /// <summary>
        /// Конструктор, который принимает сервисы пользователей и авторизации
        /// </summary>
        /// <param name="userManager">Пользовательский сервис</param>
        /// <param name="signInManager">Авторизационный сервис</param>
        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, TokensService tokensService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.tokensService = tokensService;
        }

        /// <summary>
        /// Метод аутентификации, который возвращает JWT токен (При каждой аутентификации генерируется новый JWT токен)
        /// </summary>
        /// <param name="username">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Возвращает RefreshToken</returns>
        public async Task<RefreshToken> Authenticate(string username, string password)
        {
            // Ищем пользователя по email
            User user = await _userManager.FindByEmailAsync(username);

            // Если пользователь не найден, верни ошибку о том, что такого юзера нет
            if (user == null)
                return null;

            // Иначе, пользователь найден, тогда надо сбросить куки
            var removed = await UnLoginUser(user);

            // Далее проходим авторизацию
            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

            // Если авторизация не прошла успешно, то верни null
            if (!result.Succeeded)
                return null;

            // Теперь генерируем данные для RefreshToken'a
            var encodedJwt = await GenerateJWT(user); // JWT AcessToken
            var RefreshToken = GenerateRefreshToken(); // RefreshToken



            RefreshToken token = new RefreshToken { TokenAcess = encodedJwt, IdUser = user.Id, TokenRefresh = GenerateRefreshToken() };

            // Добавляем этот токен в хранилище RefreshToken'ов


            return token; // Возвращаем токен
        }


        /// <summary>
        /// Метод, который делает рефреш токена
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Возвращает обновленный Acess токен</returns>
        public async Task<RefreshToken> RefreshToken(RefreshToken token)
        {
            // Обращаемся в БД и удостоверяемся, что рефреш токен правильный.
            var SearchedToken = token;

            // Если токен не нашли, то верни null
            if (SearchedToken == null)
                return null;

            // Иначе, если токен найден, то сгенерируй новый AcessToken
            SearchedToken.TokenAcess = await GenerateJWT(await _userManager.FindByIdAsync(SearchedToken.IdUser)); // Генерируем новый Acess Токен

            return SearchedToken; // Возвращаем обновленный Acess токен
        }

        #region Вспомогательные методы

        /// <summary>
        /// Метод генерации JWT токена, который действует, как Acess-токен
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        private async Task<string> GenerateJWT(User user)
        {
            // Далее делаем привязки
            // Ищем роли пользователя
            var userRoles = await _userManager.GetRolesAsync(user); // Ищет по айди пользователя

            // Необходимо сделать привязки токена к пользователю
            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email), // Логин к токену
                };

            // Добавляем список ролей
            foreach (var item in userRoles)
            {
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, item));
            }

            // Делаем привязки
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            // После этого создаем JWT Acess токен
            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: claimsIdentity.Claims, // Привязки
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            return new JwtSecurityTokenHandler().WriteToken(jwt); // Возвращаем JWT - acess токен
        }


        /// <summary>
        /// Метод, который сбрасывает аутентификационные куки
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <returns>TRUE, если куки сбросились. False, если произошла ошибка при сбрасывании</returns>
        private async Task<bool> UnLoginUser(User user)
        {
            try
            {
                // Обновляем секретный ключ
                await _userManager.UpdateSecurityStampAsync(user);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Метод для генерации Refresh-токена
        /// </summary>
        /// <returns>Возвращает Refresh-токен</returns>
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
