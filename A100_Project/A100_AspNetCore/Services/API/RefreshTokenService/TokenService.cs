using A100_AspNetCore.Models.ASP_Identity;
using A100_AspNetCore.Services.API._DBService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.RefreshTokenService
{

    /// <summary>
    /// Сервис-хранилище рефреш токенов
    /// </summary>

    public class TokensService
    {

        /// <summary>
        /// Метод добавляет токен в БД
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Возвращает true, если токен добавлен успешно в БД</returns>
        public async Task<bool> AddToken(RefreshTokens token)
        {
            try
            {

                // Сперва ищем токен в БД по айди юзера
                var searchedtoken = await DbUsers.db.RefreshTokens.FirstOrDefaultAsync(i => i.IdUser == token.IdUser && i.IsActive == true);

                // Если токен найден, то необходимо обновить состояние токена на false, а также создать новый
                if (searchedtoken != null)
                    searchedtoken.IsActive = false;


                // Далее добавляем новый токен, а так-же сохраняем БД
                await DbUsers.db.RefreshTokens.AddAsync(token);
                await DbUsers.db.SaveChangesAsync();


                return true; // True, т.к. токен добавлен в БД
            }
            catch (Exception)
            {               
                return false; // false, т.к. невозможно добавить токен в БД
            }


            
        }


        /// <summary>
        /// Метод, который возвращает Refresh-токен
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Возвращает RefreshToken из базы данных</returns>
        public async Task<RefreshTokens> GetToken(RefreshTokens token)
        {
            // Ищем токен
            var searchedtoken = await DbUsers.db.RefreshTokens.FirstOrDefaultAsync(i => i.TokenRefresh == token.TokenRefresh);

            // Если дата токена вышла (или он неактивен), то не возвращай токен
            if (searchedtoken.DateLifeEnd < DateTime.Now || searchedtoken.IsActive == false)
                return null;

            // Иначе, если дата токена не истекла, а также он активен, то верни токен
            return searchedtoken;

        }
    }
}
