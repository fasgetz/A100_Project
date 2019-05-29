namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientSchemePermissions
    {
        [Key]
        public int ClientSchemePermissionID { get; set; }

        public int ResoultID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string UnitName { get; set; }

        public byte PermissionType { get; set; }

        public int? X1 { get; set; }

        public int? Y1 { get; set; }

        public int? X2 { get; set; }

        public int? Y2 { get; set; }

        public virtual Resoult Resoult { get; set; }
    }
}
