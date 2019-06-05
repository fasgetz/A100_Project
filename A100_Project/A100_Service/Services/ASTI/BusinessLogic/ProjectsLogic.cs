using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI.BusinessLogic
{

    /// <summary>
    /// Класс реализует логику секции Projects
    /// </summary>

    public static class ProjectsLogic
    {

        // Метод, который получает VIK проекта по ResoultID
        public static List<v_GetVik> GetVIK(int ResoultID)
        {
            return new EFGenericRepository<v_GetVik>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.ResoultID == ResoultID);
        }


        // Метод, который получает информацию о проекте
        public static v_GetWork GetWork(int WarhouseID)
        {
            return new EFGenericRepository<v_GetWork>(new DataBase.ASTI.ASTI()).FindQueryEntity(i => i.WarhouseID == WarhouseID);
        }


        // Метод, который найден список проектов пользователя
        public static List<v_GetProjects> GetUserProjects(string login)
        {
            return new EFGenericRepository<v_GetProjects>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.MetodID == 1 && i.UserName == login);
        }
    }
}
