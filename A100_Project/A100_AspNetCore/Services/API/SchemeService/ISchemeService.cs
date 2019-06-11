using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.SchemeService
{
    public interface ISchemeService
    {
        // GET - метод, который получает зоны ответственности клиентов на складе
        Task<List<ClientSchemePermissions>> GetClientSchemePermissions(string UserID, int ResoultID);

        // GET - метод, который получает названия элементов стелажа Element
        Task<List<Element>> DictionaryElement();

        // GET - метод, который получает соответствие типов стелажей и элементов
        Task<List<ElementsOfType>> GetElementsOfType();

        // GET - метод, который получает элементы схемы стеллажа
        Task<List<v_GetMap>> GetMap(int ResoultID);

        // GET - метод, который получает названия и типы уровней риска
        Task<List<PartialTo>> GetPartialTO(int rid);
    }
}
