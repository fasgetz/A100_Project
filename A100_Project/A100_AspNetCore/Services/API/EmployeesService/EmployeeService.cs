using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Services.API._DBService;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Services.API.EmployeesService
{
    public class EmployeeService : IEmployeeService
    {


        // GET Метод, который получает список клиентов А100
        public async Task<List<Employee>> GetEmployeesClients()
        {
            return await MyDB.db.Employee.ToListAsync();
        }
    }
}
