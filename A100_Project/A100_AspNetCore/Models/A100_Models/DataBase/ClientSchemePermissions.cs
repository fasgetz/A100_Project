using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ClientSchemePermissions
    {
        public int ClientSchemePermissionId { get; set; }
        public int ResoultId { get; set; }
        public string UserId { get; set; }
        public string UnitName { get; set; }
        public byte PermissionType { get; set; }
        public int? X1 { get; set; }
        public int? Y1 { get; set; }
        public int? X2 { get; set; }
        public int? Y2 { get; set; }

        public virtual Resoult Resoult { get; set; }
    }
}
