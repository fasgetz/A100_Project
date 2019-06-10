using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Models.API
{

    /// <summary>
    /// Сущность для аутентификации в АПИ
    /// </summary>


    public class AuthModel
    {
        public string login { get; set; }
        public string password { get; set; }
    }
}
