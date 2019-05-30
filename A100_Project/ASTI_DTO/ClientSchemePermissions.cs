namespace ASTI_DTO
{
    public class ClientSchemePermissions
    {
        public int ClientSchemePermissionID { get; set; }

        public int ResoultID { get; set; }

        public string UserID { get; set; }

        public string UnitName { get; set; }

        public byte PermissionType { get; set; }

        public int? X1 { get; set; }

        public int? Y1 { get; set; }

        public int? X2 { get; set; }

        public int? Y2 { get; set; }

        public virtual Resoult Resoult { get; set; }
    }
}
