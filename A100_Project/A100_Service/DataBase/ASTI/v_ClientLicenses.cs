namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ClientLicenses
    {
        [Key]
        [Column(Order = 0)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LicenseID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LicenseCount { get; set; }

        public int? LicenseRemained { get; set; }

        public DateTime? LicenseBestBefore { get; set; }

        public bool? isActive { get; set; }

        [StringLength(500)]
        public string LicenseDocument { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }
    }
}
