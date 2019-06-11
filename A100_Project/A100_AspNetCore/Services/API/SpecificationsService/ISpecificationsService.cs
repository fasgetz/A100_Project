using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.SpecificationsService
{
    public interface ISpecificationsService
    {
        // GET - метод, который получает спецификации (типы стелажей) по ResoultID
        Task<List<Specifications>> GetSpecifications(int ResoultID);

        // GET - метод, который получает элементы стеллажей по ResoultID
        Task<List<v_GetSpecificationsElement>> GetSpecificationElement(int ResoultID);

        // GET - метод, который получает спецификации (типы стелажей) по ResoultID
        Task<List<Deviation>> GetDeviation(int ResoultID);

        // GET - метод, который получает типы дефектов
        Task<List<DefectType>> GetDefectTypes();

        // GET - метод, который получает названия и типы уровней риска
        Task<List<RiskLevel>> DictionaryRiskLevel();

        // GET - метод, который получает названия и типы уровней риска
        Task<List<ClientPermissions>> GetUserRoles();



    }
}
