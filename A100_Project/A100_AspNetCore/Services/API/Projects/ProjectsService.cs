using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Services.API.Projects
{
    public class ProjectsService : IProjectsService
    {
        private ASTIContext db; // Контекст базы данных

        public ProjectsService(ASTIContext context)
        {
            db = context;
        }

        // GET - метод, который получает ТЗ
        public async Task<Control> GetProjectData(string project)
        {
            return await db.Control.FirstOrDefaultAsync(i => i.ProjectNumber == project);
        }

        // Список проектов пользователя
        public async Task<List<v_GetProjects>> GetUserProjects(string username)
        {
            return await db.v_GetProjects.Where(i => i.MetodID == 1 && i.UserName == username).ToListAsync();
        }

        // Информация о проекте
        public async Task<v_GetWork> GetWork(int WarhouseID)
        {
            return await db.v_GetWork.FirstOrDefaultAsync(i => i.WarhouseID == WarhouseID);
        }
    }
}
