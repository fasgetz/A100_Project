using ASTI_DTO;

namespace ASTI_DTOTI
{

    public class ClientLicense
    {
        public int ClientLicenseID { get; set; }


        public string UserID { get; set; }

        public int LicenseID { get; set; }

        public virtual Licenses Licenses { get; set; }
    }
}
