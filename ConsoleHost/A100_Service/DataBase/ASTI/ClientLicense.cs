namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientLicense")]
    public partial class ClientLicense
    {
        public int ClientLicenseID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public int LicenseID { get; set; }

        public virtual Licenses Licenses { get; set; }
    }
}
