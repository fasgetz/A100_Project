using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Services.API.EmployeesService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.API.Controllers
{
    /// <summary>
    /// Контроллер работников
    /// </summary>

    [Route("api/[Controller]")]
    [Authorize]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService service; // Сервис

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }


        #region Методы контроллера

        // GET Метод, который получает список клиентов А100
        [HttpGet]
        [Route("EmployeesClients")]
        public async Task<List<Employee>> GetEmployeesClients()
        {
            return await service.GetEmployeesClients();
        }

        #endregion
    }
}
