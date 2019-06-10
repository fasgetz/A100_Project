using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ClientLicense
    {
        public int ClientLicenseId { get; set; }
        public string UserId { get; set; }
        public int LicenseId { get; set; }

        public virtual Licenses License { get; set; }
    }
}
