using A100_AspNetCore.Services.API.RefreshTokenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API
{

    /// <summary>
    /// Интерфейс описывает пользовательский сервис
    /// </summary>


    public interface IUserService
    {
        /// <summary>
        /// // Метод, который делает аутентификацию юзера
        /// </summary>
        /// <param name="username">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Вовзращает Acess и Refresh токены</returns>
        Task<RefreshToken> Authenticate(string username, string password);


        /// <summary>
        /// Метод, который делает рефреш токена
        /// </summary>
        /// <param name="token">Токен</param>
        /// <returns>Возвращает обновленный Acess токен</returns>
        Task<RefreshToken> RefreshToken(RefreshToken token);

    }
}
