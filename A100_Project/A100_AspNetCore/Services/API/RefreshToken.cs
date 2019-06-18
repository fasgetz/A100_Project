using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API
{

    /// <summary>
    /// Рефреш токен
    /// </summary>
    public class RefreshToken
    {
        public string UserID { get; set; } // Айди юзера

        public string token { get; set; } // Токен

        public DateTime DateExpirence { get; set; } // Конец жизни токена
    }
}
