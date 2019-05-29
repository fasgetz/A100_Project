using System;
using System.Collections.Generic;
using System.Text;

namespace aspASTI_DTO
{
    public class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public string Id { get; set; }

        public string Name { get; set; }


        public string Name_RU { get; set; }

        public byte? RoleType { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
