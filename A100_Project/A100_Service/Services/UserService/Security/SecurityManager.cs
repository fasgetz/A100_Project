using A100_Service.DataBase.aspASTI;
using A100_Service.DataBase.Repositories;
using A100_Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
        public Token AddToken(string UserLogin)
        {

            // Ищем токен по логину
            var token = GetTokenLogin(UserLogin);

            // Если токен не найден, то создай его и добавь в список активных токенов
            if (token == null)
            {
                // Создаем контекст для работы с БД и ищем пользователя
                var rep = new EFGenericRepository<AspNetUsers>(new aspASTI()); // Контекст для работы с БД
                var user = rep.FindQueryEntity(i => i.Email == UserLogin); // Ищем пользователя
                
                // Если пользователь найден
                if (user != null)
                {
                    Console.WriteLine(user.EmailConfirmed.ToString());
                    token = new Token(UserLogin, 60 * 60 * 24, user); // Создаем новый токен
                    tokens.Add(token); // Добавляем в список
                }


                
            }

            return token; // Возвращаем сам ключ токена
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
            // Ищем токен по логину
            var token = ActiveToken(tokens.FirstOrDefault(i => i.token == TokenName));

            // Если токен найден, то верни его
            if (token != null)
                return token;

            // Если токен не найден, то выдай экзепшен
            throw new FaultException<MyException>(new MyException("Вам отказано в доступе"),
                new FaultReason("Токен не найден"));

            //// Возвращаем токен пользователю, который ищем по логину
            //return ActiveToken(tokens.FirstOrDefault(i => i.token == TokenName));
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
