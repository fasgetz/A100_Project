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
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API
{

    /// <summary>
    /// Класс описывает логику работы авторизации API
    /// </summary>

    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAcessor;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, IHttpContextAccessor tp)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAcessor = tp;
        }   


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


            // Устанавливаем сессию
            _httpContextAcessor.HttpContext.Session.SetString(SessionKeyName, "tests");
            _httpContextAcessor.HttpContext.Session.SetInt32(SessionKeyYearsMember, 3324);


            // Возвращаем токен
            return encodedJwt;
        }

        // Ключи сессии
        const string SessionKeyName = "_Name";
        const string SessionKeyYearsMember = "_YearsMember";
        const string SessionKeyDate = "_Date";

        // Делаем привязку токена, если пользователь найден
        private async Task<ClaimsIdentity> GetIdentity(string username, string password)
        {

            // Ищем пользователя по email
            User user = await _userManager.FindByEmailAsync(username);            

            // Если пользователь не найден, верни ошибку о том, что такого юзера нет
            if (user == null)
                return null;

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
    }
}
