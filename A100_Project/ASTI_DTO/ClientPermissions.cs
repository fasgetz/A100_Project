namespace ASTI_DTO
{

    public class ClientPermissions
    {
        public int ClientPermissionID { get; set; }

        public string UserID { get; set; }

        public bool? CreatingPTO { get; set; }

        public bool? EditingSchema { get; set; }
    }
}
