using A100_AspNetCore.Models.API;
using A100_AspNetCore.Models.ASP_Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API._DBService
{
    /// <summary>
    /// Для работы с базой данных юзеров
    /// </summary>

    public static partial class DbUsers
    {
        public static TestDBContext db = new TestDBContext();
    }
}
