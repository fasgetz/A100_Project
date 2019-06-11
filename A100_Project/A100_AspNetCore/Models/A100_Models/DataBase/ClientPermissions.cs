using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ClientPermissions
    {
        public int ClientPermissionId { get; set; }
        public string UserId { get; set; }
        public bool? CreatingPto { get; set; }
        public bool? EditingSchema { get; set; }
    }
}
