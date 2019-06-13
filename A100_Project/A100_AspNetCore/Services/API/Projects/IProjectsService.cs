using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.Projects
{

    /// <summary>
    /// Интерфейс описывает поведение проектов
    /// </summary>


    public interface IProjectsService
    {
        //// GET - метод, который возвращает список проектов пользователя
        Task<List<v_GetProjects>> GetUserProjects(string username);

        // GET - метод, который получает информацию о проекте
        Task<v_GetWork> GetWork(int WarhouseID);

        // GET - метод, который получает названия и типы уровней риска
        Task<Control> GetProjectData(string projectname);
    }
}
