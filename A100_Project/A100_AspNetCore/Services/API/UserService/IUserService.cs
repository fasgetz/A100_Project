using A100_AspNetCore.Models.ASP_Identity;
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
        Task<RefreshTokens> Authenticate(string username, string password);


        /// <summary>
        /// Метод, который делает рефреш токена
        /// </summary>
        /// <param name="token">Токен</param>
        /// <returns>Возвращает обновленный Acess токен</returns>
        Task<RefreshTokens> RefreshToken(RefreshTokens token);

    }
}
