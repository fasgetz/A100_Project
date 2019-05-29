namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_Clients
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(256)]
        public string UserName { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Enabled { get; set; }

        public string Companies { get; set; }

        public string Warhouses { get; set; }

        [StringLength(250)]
        public string UserKey { get; set; }
    }
}
