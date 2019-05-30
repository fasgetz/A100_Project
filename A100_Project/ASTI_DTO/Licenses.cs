namespace ASTI_DTO
{
    using ASTI_DTOTI;
    using System;
    using System.Collections.Generic;

    public class Licenses
    {
        public Licenses()
        {
            ClientLicense = new HashSet<ClientLicense>();
        }

        public int LicenseID { get; set; }

        public int? CompanyID { get; set; }

        public int? WarhouseID { get; set; }

        public int LicenseCount { get; set; }

        public int? LicenseRemained { get; set; }

        public DateTime? LicenseBestBefore { get; set; }

        public int? ParentLicenseID { get; set; }

        public bool? isActive { get; set; }

        public string LicenseDocument { get; set; }

        public virtual ICollection<ClientLicense> ClientLicense { get; set; }

        public virtual Company Company { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
