using A100_AspNetCore.Services.API.RefreshTokenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.RefreshTokenService
{
    public class TokensService
    {
        List<RefreshToken> list; // Список Refresh-токенов

        public TokensService()
        {
            list = new List<RefreshToken>();
        }


        public void AddToken(RefreshToken token)
        {
            // Если токен не найден, то добавь в список
            if (list.FirstOrDefault(i => i.TokenAcess == token.TokenAcess) == null)
                list.Add(token);
        }

        /// <summary>
        /// Метод рефреша токена
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public RefreshToken RefreshToken(RefreshToken token)
        {
            return list.FirstOrDefault(i => i.TokenAcess == token.TokenAcess);
        }
    }
}
