namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientPermissions
    {
        [Key]
        [Column(Order = 0)]
        public int ClientPermissionID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string UserID { get; set; }

        public bool? CreatingPTO { get; set; }

        public bool? EditingSchema { get; set; }
    }
}
