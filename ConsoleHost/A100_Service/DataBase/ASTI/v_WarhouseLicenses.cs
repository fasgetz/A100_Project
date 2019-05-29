namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_WarhouseLicenses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarhouseID { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(300)]
        public string WarhouseAddress { get; set; }

        public int? LicenseCount { get; set; }

        public int? LicenseRemained { get; set; }

        public DateTime? LicenseBestBefore { get; set; }

        public int? CompanyID { get; set; }

        public int? ParentLicenseID { get; set; }

        public bool? isActive { get; set; }

        [StringLength(500)]
        public string LicenseDocument { get; set; }

        public int? LicenseID { get; set; }
    }
}
