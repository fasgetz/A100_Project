using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API
{

    /// <summary>
    /// Интерфейс описывает пользовательский сервис
    /// </summary>


    public interface IUserService
    {
        // Метод, который делает аутентификацию юзера и возвращает токен
        string Authenticate(string username, string password);

    }
}
