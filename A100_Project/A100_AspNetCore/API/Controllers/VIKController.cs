using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using A100_AspNetCore.Services.API.VikService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A100_AspNetCore.API.Controllers
{

    [Route("api/[Controller]")]
    [Authorize]
    [ApiController]
    public class VIKController : ControllerBase
    {
        IVikService service;

        public VIKController(IVikService service)
        {
            this.service = service;
        }


        #region Методы контроллера


        // GET - метод, который получает VIK по ResoultID
        [HttpGet]
        [Route("GetVik")]
        public async Task<List<v_GetVik>> GetVik([FromBody]v_GetVik vik)
        {
            return await service.GetVik(vik.ResoultID);
        }


        // GET - метод, который получает названия VIK
        [HttpGet]
        [Route("GetVikNames")]
        public async Task<List<VikElement>> GetVikNames()
        {
            return await service.GetVikNames();
        }


        #endregion


    }
}
