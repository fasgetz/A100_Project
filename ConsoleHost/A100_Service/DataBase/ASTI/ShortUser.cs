namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShortUser")]
    public partial class ShortUser
    {
        public short ShortUserID { get; set; }

        [Required]
        [StringLength(250)]
        public string UserKey { get; set; }

        [StringLength(10)]
        public string Test { get; set; }
    }
}
