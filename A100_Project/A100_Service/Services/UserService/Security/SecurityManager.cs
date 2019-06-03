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
            tokens = new List<Token>();
        }


        #region Методы

        // Метод, который удаляет просроченные токены
        // (Проходится по списку и сравнивает текущую дату с датой, которая является концом срока токена)
        public void DisposeToken(object obj)
        {
            Console.WriteLine($"Очищение {System.DateTime.Now}");

            lock (tokens)
            {
                // Перебираем токены
                foreach (var item in tokens)
                {
                    // Если срок истек, то убери, пожалуйста, из списка токенов
                    if (item.EndDate < System.DateTime.Now)
                        tokens.Remove(item); // Убираем из списка токенов
                }
            }



            Console.WriteLine($"Всего активных токенов на данный момент {tokens?.Count}");
        }

        // Метод, который добавляет токен в список и возвращает этот токен
        public string AddToken(Token token)
        {
            lock (tokens)
            {
                // Если у пользователя нету суточного токена, то выдели ему. Иначе отклони
                if (tokens.FirstOrDefault(i => i.UserLogin == token.UserLogin) == null)
                {
                    tokens.Add(token); // Добавь, пожалуйста, токен в список. Т.к. удолетворяет условию

                    // Запускаем метод, который удалит токен через определенное время
                    Thread thread = new Thread(() =>
                    {
                        new TimerCallback(() =>
                        {

                        }, 0, 0, 0);
                    });
                    thread.Start();
                }
                    

                return GetToken(token.UserLogin).token; // Возвращаем токен
            }

        }


        // Метод, который возвращает токен,  если он у него есть конечно же)))
        public Token GetToken(string login)
        {
            // Возвращаем токен, если есть совпадение по логину
            return tokens.FirstOrDefault(i => i.UserLogin == login);
        }

        // Метод, который показывает сколько осталось жить токену
        public string GetLifeDate(string token)
        {
            lock (tokens)
            {
                // Находим токен
                var findtoken = tokens.FirstOrDefault(i => i.token == token);

                // Если токен найден, то верни дату
                if (findtoken != null)
                {
                    var time = findtoken.EndDate.Subtract(System.DateTime.Now);
                    //Console.WriteLine(time.ToString());
                    return time.ToString(); // Возвращаем разницу дат (Оставшееся время = Дата конца токена - текущее время)
                }

                return null;
            }

        }

        #endregion



    }
}
