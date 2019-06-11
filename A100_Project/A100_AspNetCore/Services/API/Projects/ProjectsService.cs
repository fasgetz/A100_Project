using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using A100_AspNetCore.Services.API._DBService;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Services.API.Projects
{
    public class ProjectsService : IProjectsService
    {
        // GET - метод, который получает ТЗ
        public async Task<Control> GetProjectData(string projectname)
        {
            return await MyDB.db.Control.FirstOrDefaultAsync(i => i.ProjectNumber == projectname);
        }

        // Список проектов пользователя
        public async Task<List<v_GetProjects>> GetUserProjects(string username)
        {
            return await MyDB.db.v_GetProjects.Where(i => i.MetodID == 1 && i.UserName == username).ToListAsync();
        }

        // Информация о проекте
        public async Task<v_GetWork> GetWork(int WarhouseID)
        {
            return await MyDB.db.v_GetWork.FirstOrDefaultAsync(i => i.WarhouseID == WarhouseID);
        }
    }
}
