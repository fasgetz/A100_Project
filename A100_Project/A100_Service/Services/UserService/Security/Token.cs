using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.UserService.Security
{
    /// <summary>
    /// Сущность токена. Токен - уникальный ключ, который позволяет работать с нашим API
    /// </summary>

    public class Token
    {
        public string token { get; set; } // Сам ключ
        public DateTime startDate { get; set; } // Дата создания токена
        public DateTime EndDate { get; set; } // Конец срока токена

        public string UserLogin { get; set; } // Логин пользователя, который пользуется токеном


        // Конструктор
        public Token(string UserLogin, int second)
        {
            this.token = TokenGenerator.GenerateToken(); // Генерируем токен
            this.startDate = System.DateTime.Now; // Текущая дата
            this.EndDate = startDate.AddSeconds(second); // Время жизни токена + seconds (в секундах)


            this.UserLogin = UserLogin; // Присваиваем логин пользователя токену
        }
    }
}
