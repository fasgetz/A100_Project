using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using A100_AspNetCore.Services.API._DBService;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Services.API.SpecificationsService
{
    public class SpecificationsService : ISpecificationsService
    {
        // GET - метод, который получает названия и типы уровней риска
        public Task<List<RiskLevel>> DictionaryRiskLevel()
        {
            return MyDB.db.RiskLevel.ToListAsync();
        }

        // GET - метод, который получает типы дефектов
        public Task<List<DefectType>> GetDefectTypes()
        {
            return MyDB.db.DefectType.ToListAsync();
        }

        // GET - метод, который получает спецификации (типы стелажей) по ResoultID
        public Task<List<Deviation>> GetDeviation(int ResoultID)
        {
            return MyDB.db.Deviation.Where(i => i.ResoultId == ResoultID).ToListAsync();
        }

        // GET - метод, который получает элементы стеллажей по ResoultID
        public Task<List<v_GetSpecificationsElement>> GetSpecificationElement(int ResoultID)
        {
            return MyDB.db.v_GetSpecificationsElement.Where(i => i.ResoultID == ResoultID).ToListAsync();
        }

        // GET - метод, который получает спецификации (типы стелажей) по ResoultID
        public Task<List<Specifications>> GetSpecifications(int ResoultID)
        {
            return MyDB.db.Specifications.Where(i => i.ResoultId == ResoultID).ToListAsync();
        }

        // GET - метод, который получает роли
        public Task<List<ClientPermissions>> GetUserRoles()
        {
            return MyDB.db.ClientPermissions.ToListAsync();
        }
    }
}
