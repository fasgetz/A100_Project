using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI.BusinessLogic
{
    public static class SchemeLogic
    {
        public static List<v_GetMap> GetMap(int ResoultID)
        {
            return new EFGenericRepository<v_GetMap>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.ResoultID == ResoultID);
        }

        public static List<PartialTO> GetPartialTO(int ResoultID)
        {
            return new EFGenericRepository<PartialTO>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.ResoultID == ResoultID);
        }
    }
}
