namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Licenses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Licenses()
        {
            ClientLicense = new HashSet<ClientLicense>();
        }

        [Key]
        public int LicenseID { get; set; }

        public int? CompanyID { get; set; }

        public int? WarhouseID { get; set; }

        public int LicenseCount { get; set; }

        public int? LicenseRemained { get; set; }

        public DateTime? LicenseBestBefore { get; set; }

        public int? ParentLicenseID { get; set; }

        public bool? isActive { get; set; }

        [StringLength(500)]
        public string LicenseDocument { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientLicense> ClientLicense { get; set; }

        public virtual Company Company { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
