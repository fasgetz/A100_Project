using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.RefreshTokenService.Models
{

    /// <summary>
    /// Сущность RefreshToken'a обновления
    /// </summary>

    public class RefreshToken
    {
        public string TokenAcess { get; set; } // Имя токена Access

        public string TokenRefresh { get; set; } // Имя токена Refresh

        public string IdUser { get; set; } // Айди юзера
    }


}
