namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ControlEmployees
    {
        [Key]
        public int ControlEmployeeID { get; set; }

        public int ControlID { get; set; }

        public int EmployeeID { get; set; }

        public virtual Control Control { get; set; }
    }
}
