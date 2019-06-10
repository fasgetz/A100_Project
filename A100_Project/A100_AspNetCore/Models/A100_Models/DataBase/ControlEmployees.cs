using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ControlEmployees
    {
        public int ControlEmployeeId { get; set; }
        public int ControlId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Control Control { get; set; }
    }
}
