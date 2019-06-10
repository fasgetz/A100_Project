using A100_AspNetCore.Models.A100_Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.EmployeesService
{
    public interface IEmployeeService
    {
        // GET - метод, который получает список клиентов, имеющих доступ в приложение
        Task<List<Employee>> GetEmployeesClients();


    }
}
