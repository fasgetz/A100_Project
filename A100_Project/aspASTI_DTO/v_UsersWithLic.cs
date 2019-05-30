using System;
using System.Collections.Generic;
using System.Text;

namespace aspASTI_DTO
{
    public class v_UsersWithLic
    {

        public string Id { get; set; }

        public string UserName { get; set; }

        public int? LicenseID { get; set; }

        public string Email { get; set; }

        public int IsSuperAgent { get; set; }


        public int IsMegaAgent { get; set; }

        public string RealName { get; set; }

        public string RealUserName { get; set; }
    }
}
