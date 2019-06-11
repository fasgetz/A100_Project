using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using A100_AspNetCore.Services.API.SchemeService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.API.Controllers
{

    [Route("api/[Controller]")]
    [Authorize]
    [ApiController]
    public class SchemeController : ControllerBase
    {
        ISchemeService service;

        public SchemeController(ISchemeService service)
        {
            this.service = service;
        }

        #region Секция методов

        // GET Метод, который получает весь список городов
        [HttpGet]
        [Route("GetDictionaryElement")]
        public async Task<List<Element>> DictionaryElement()
        {
            return await service.DictionaryElement();
        }

        [HttpGet]
        [Route("GetClientSchemePermissions")]
        // GET - метод, который получает зоны ответственности клиентов на складе
        public async Task<List<ClientSchemePermissions>> GetClientSchemePermissions([FromBody]ClientSchemePermissions scheme)
        {
            return await service.GetClientSchemePermissions(scheme.UserId, scheme.ResoultId);
        }

        [HttpGet]
        [Route("GetElementsOfType")]
        // GET - метод, который получает соответствие типов стелажей и элементов
        public async Task<List<ElementsOfType>> GetElementsOfType()
        {
            return await service.GetElementsOfType();
        }

        [HttpGet]
        [Route("GetMap")]
        // GET - метод, который получает элементы схемы стеллажа
        public async Task<List<v_GetMap>> GetMap([FromBody]v_GetMap map)
        {
            return await service.GetMap(map.ResoultID);
        }

        [HttpGet]
        [Route("GetPartialTO")]
        // GET - метод, который получает названия и типы уровней риска
        public async Task<List<PartialTo>> GetPartialTO([FromBody]PartialTo to)
        {
            return await service.GetPartialTO(to.ResoultId);
        }

        #endregion

    }
}
