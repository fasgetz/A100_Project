namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class ControlEmployees
    {
        public int ControlEmployeeID { get; set; }

        public int ControlID { get; set; }

        public int EmployeeID { get; set; }

        public virtual Control Control { get; set; }
    }
}
