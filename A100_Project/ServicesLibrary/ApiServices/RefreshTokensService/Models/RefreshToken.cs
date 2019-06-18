using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary.ApiServices.RefreshTokensService.Models
{
    class RefreshToken
    {
        public string TokenAcess { get; set; } // Имя токена Access

        public string TokenRefresh { get; set; } // Имя токена Refresh

        public string IdUser { get; set; } // Айди юзера
    }
}
