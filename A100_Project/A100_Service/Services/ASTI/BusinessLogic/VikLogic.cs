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
    /// Логика IVik
    /// </summary>

    public static class VikLogic
    {        

        // Метод, который получает VIK проекта по ResoultID
        public static List<v_GetVik> GetVIK(int ResoultID)
        {
            return new EFGenericRepository<v_GetVik>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.ResoultID == ResoultID);
        }

        // Метод, который получает названия VIK
        public static List<VikElement> GetVikNames()
        {
            return new EFGenericRepository<VikElement>(new DataBase.ASTI.ASTI()).GetAllList();
        }
    }
}
