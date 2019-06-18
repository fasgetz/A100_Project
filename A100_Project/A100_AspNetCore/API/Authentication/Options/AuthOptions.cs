﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100_AspNetCore.API.Authentication.Options
{

    /// <summary>
    /// Параметры аутентификации
    /// </summary>

    public class AuthOptions
    {
        public const string ISSUER = "A100"; // издатель токена
        public const string AUDIENCE = "http://localhost:61896/"; // потребитель токена
        const string KEY = "mysupersecret_secretkey!123";   // ключ для шифрации
        public const int LIFETIME = 1 * 10; // время жизни Acess токена - 10 минут
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }


        // Свой валидатор времени
        public static bool CustomLifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        {
            if (expires != null)
            {
                return DateTime.UtcNow < expires;
            }
            return false;
        }
    }
}
