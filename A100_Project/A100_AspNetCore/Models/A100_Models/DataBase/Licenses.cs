using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Licenses
    {
        public Licenses()
        {
            ClientLicense = new HashSet<ClientLicense>();
        }

        public int LicenseId { get; set; }
        public int? CompanyId { get; set; }
        public int? WarhouseId { get; set; }
        public int LicenseCount { get; set; }
        public int? LicenseRemained { get; set; }
        public DateTime? LicenseBestBefore { get; set; }
        public int? ParentLicenseId { get; set; }
        public bool? IsActive { get; set; }
        public string LicenseDocument { get; set; }

        public virtual Company Company { get; set; }
        public virtual Warhouse Warhouse { get; set; }
        public virtual ICollection<ClientLicense> ClientLicense { get; set; }
    }
}
