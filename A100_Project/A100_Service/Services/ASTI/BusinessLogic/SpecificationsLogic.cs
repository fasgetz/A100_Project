using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI.BusinessLogic
{
    public static class SpecificationsLogic
    {
        public static List<Specifications> GetSpecifications(int ResoultID)
        {
            return new EFGenericRepository<Specifications>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.ResoultID == ResoultID);
        }

        public static List<v_GetSpecificationsElement> GetSpecificationsElement(int ResoultID)
        {
            return new EFGenericRepository<v_GetSpecificationsElement>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.ResoultID == ResoultID);
        }

        public static List<Deviation> GetDeviation(int ResoultID)
        {
            return new EFGenericRepository<Deviation>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.ResoultID == ResoultID);
        }

        public static List<DefectType> GetDefectTypes()
        {
            return new EFGenericRepository<DefectType>(new DataBase.ASTI.ASTI()).GetAllList();
        }

        public static List<RiskLevel> DictionaryRiskLevel()
        {
            return new EFGenericRepository<RiskLevel>(new DataBase.ASTI.ASTI()).GetAllList();
        }

        public static List<ClientPermissions> GetClientPermissions()
        {
            return new EFGenericRepository<ClientPermissions>(new DataBase.ASTI.ASTI()).GetAllList();
        }
    }
}
