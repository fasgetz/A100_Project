using System;

namespace A100_Service.Services.UserService.Security
{
    /// <summary>
    /// Токен генератор - статический класс, который генерирует уникальные ключи (токены)
    /// </summary>

    public static class TokenGenerator
    {

        // Метод, который генерирует токен
        public static string GenerateToken()
        {
            var token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            token = token.Replace('+', '_'); // Заменяем символ +, т.к. json не поддерживает +
            return token;
        }

    }


}
