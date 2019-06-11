using A100_AspNetCore.Models.A100_Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API._DBService
{
    /// <summary>
    /// Для работы с базой данных
    /// </summary>

    public static partial class MyDB
    {
        public static ASTIContext db = new ASTIContext();
    }
}
