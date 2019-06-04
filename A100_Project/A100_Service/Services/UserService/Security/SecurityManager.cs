using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A100_Service.Services.UserService.Security
{

    /// <summary>
    /// Класс, который предоставляет безопасность системы
    /// </summary>

    class SecurityManager
    {
        #region Свойства

        private List<Token> tokens; // Список действующих текенов

        #endregion

        public SecurityManager()
        {
            tokens = new List<Token>(); // Инициализируем список активных токенов
        }


        #region Методы
        

        // Метод, который добавляет токен в список и возвращает этот токен
        public string AddToken(string UserLogin)
        {

            // Ищем токен по логину
            var token = GetTokenLogin(UserLogin);

            // Если токен не найден, то создай его и добавь в список активных токенов
            if (token == null)
            {
                token = new Token(UserLogin, 20); // Создаем новый токен
                tokens.Add(token);

                
            }

            return token.token; // Возвращаем сам ключ токена
        }


        // Вспомогательный метод, который проверяет токен на жизнедеятельность и удаляет его, если жизнь завершена
        private Token ActiveToken(Token token)
        {
            // Если токен не пустой
            if (token != null)
            {
                // Если жизненный цикл токена не завершен, то верни его
                if (token.EndDate > System.DateTime.Now)
                    return token; // Возвращаем токен

                // Иначе удаляем токен из коллекции
                tokens.Remove(token);
            }

            // Возвращаем null, если не удолетворяет ни одному условию
            return null;
        }
        


        // Метод, который возвращает токен по логину
        public Token GetTokenLogin(string login)
        {
            // Возвращаем токен пользователю, который ищем по логину
            return ActiveToken(tokens.FirstOrDefault(i => i.UserLogin == login));
        }

        public Token GetTokenName(string TokenName)
        {
            // Возвращаем токен пользователю, который ищем по логину
            return ActiveToken(tokens.FirstOrDefault(i => i.token == TokenName));
        }


        // Метод, который показывает сколько осталось жить токену
        public string GetLifeDate(string token)
        {
            var FindToken = GetTokenName(token); // Ищем токен

            // Если токен найден, то верни дату
            if (FindToken != null)
            {
                var time = FindToken.EndDate.Subtract(System.DateTime.Now);
                return time.ToString(); // Возвращаем разницу дат (Оставшееся время = Дата конца токена - текущее время)
            }


            // Возвращаем null, если токен не найден
            return "Токен не найден";
        }

        #endregion



    }
}
