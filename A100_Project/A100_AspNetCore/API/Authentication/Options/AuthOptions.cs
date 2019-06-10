using Microsoft.IdentityModel.Tokens;
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
        public const int LIFETIME = 1; // время жизни токена - 1 минута
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
