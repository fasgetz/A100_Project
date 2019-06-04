using A100_Service.DataBase.aspASTI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.UserService.Security
{
    /// <summary>
    /// Сущность токена. Токен - уникальный ключ, который позволяет работать с нашим API
    /// </summary>

    [DataContract]
    public class Token
    {

        [DataMember]
        public string UserID { get; set; } // Айди пользователя

        [DataMember]
        public string RealFIO { get; set; } // Фио пользователя

        [DataMember]
        public string token { get; set; } // Сам ключ

        [DataMember]
        public DateTime startDate { get; set; } // Дата создания токена

        [DataMember]
        public DateTime EndDate { get; set; } // Конец срока токена

        [DataMember]
        public string UserLogin { get; set; } // Логин пользователя, который пользуется токеном


        // Конструктор
        public Token(string login, int second, AspNetUsers user)
        {
            this.token = TokenGenerator.GenerateToken(); // Генерируем токен
            this.startDate = System.DateTime.Now; // Текущая дата
            this.EndDate = startDate.AddSeconds(second); // Время жизни токена + seconds (в секундах)
            this.UserLogin = login; // Присваиваем логин пользователя токену

            this.RealFIO = user.RealUserName;
            this.UserID = user.Id;
        }
    }
}
