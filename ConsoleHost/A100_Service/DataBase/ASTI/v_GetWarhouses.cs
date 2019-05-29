namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetWarhouses
    {
        [StringLength(150)]
        public string WarhouseName { get; set; }

        public int? WKey { get; set; }

        [StringLength(250)]
        public string UserKey { get; set; }

        [Key]
        public bool Enabled { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }

        public DateTime? ExperyDate { get; set; }
    }
}
