using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using A100_AspNetCore.Services.API.Projects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A100_AspNetCore.API.Controllers
{
    [Route("api/[Controller]")]
    [Authorize]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        IProjectsService service;

        public ProjectsController(IProjectsService service)
        {
            this.service = service;
        }


        // GET Метод, который получает проект
        [HttpGet]
        [Route("GetWork")]
        public async Task<v_GetWork> GetWork([FromBody]v_GetWork work)
        {
            return await service.GetWork(Convert.ToInt32(work.WarhouseID));
        }

        // GET Метод, который получает проект
        [HttpGet]
        [Route("GetUserProjects")]
        public async Task<List<v_GetProjects>> GetUserProjects([FromBody]v_GetProjects projects)
        {
            return await service.GetUserProjects(projects.UserName);
        }

        // GET Метод, который получает проект
        [HttpGet]
        [Route("GetWork")]
        public async Task<Control> GetProjectData([FromBody]Control control)
        {
            return await service.GetProjectData(control.ProjectNumber);
        }
    }
}
