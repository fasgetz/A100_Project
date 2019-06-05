using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI.BusinessLogic
{
    public static class ClientsLogic
    {
        public static List<Employee> GetEmployeesClients()
        {
            return new EFGenericRepository<Employee>(new DataBase.ASTI.ASTI()).GetQueryList(i => i.isClient == false);
        }
    }
}
