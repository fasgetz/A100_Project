using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using A100_AspNetCore.Services.API._DBService;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Services.API.SchemeService
{
    public class SchemeService : ISchemeService
    {
        // GET - метод, который получает названия элементов стелажа Element
        public Task<List<Element>> DictionaryElement()
        {
            return MyDB.db.Element.ToListAsync();
        }

        // GET - метод, который получает зоны ответственности клиентов на складе
        public Task<List<ClientSchemePermissions>> GetClientSchemePermissions(string UserID, int ResoultID)
        {
            return MyDB.db.ClientSchemePermissions.Where(i => i.UserId == UserID && i.ResoultId == ResoultID).ToListAsync();
        }

        // GET - метод, который получает соответствие типов стелажей и элементов
        public Task<List<ElementsOfType>> GetElementsOfType()
        {
            return MyDB.db.ElementsOfType.ToListAsync();
        }

        // GET - метод, который получает элементы схемы стеллажа
        public Task<List<v_GetMap>> GetMap(int ResoultID)
        {
            return MyDB.db.v_GetMap.Where(i => i.ResoultID == ResoultID).ToListAsync();
        }

        // GET - метод, который получает названия и типы уровней риска
        public Task<List<PartialTo>> GetPartialTO(int rid)
        {
            return MyDB.db.PartialTo.Where(i => i.ResoultId == rid).ToListAsync();
        }
    }
}
