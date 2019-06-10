using A100_AspNetCore.Models.A100_Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.SchemeService
{
    interface ISchemeService
    {
        // GET - метод, который получает зоны ответственности клиентов на складе
        Task<List<ClientSchemePermissions>> GetClientSchemePermissions(string UserID, int ResoultID);

        // GET - метод, который получает названия элементов стелажа Element
        List<Element> DictionaryElement();

        // GET - метод, который получает соответствие типов стелажей и элементов
        List<ElementsOfType> GetElementsOfType();
    }
}
