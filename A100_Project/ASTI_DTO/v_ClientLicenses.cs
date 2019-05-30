namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ClientLicenses
    {
        public string UserID { get; set; }

        public int LicenseID { get; set; }

        public int LicenseCount { get; set; }

        public int? LicenseRemained { get; set; }

        public DateTime? LicenseBestBefore { get; set; }

        public bool? isActive { get; set; }

        public string LicenseDocument { get; set; }

        public string WarhouseName { get; set; }

        public string CompanyName { get; set; }
    }
}
