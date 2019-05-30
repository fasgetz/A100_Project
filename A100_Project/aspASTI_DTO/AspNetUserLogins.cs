using System;
using System.Collections.Generic;
using System.Text;

namespace aspASTI_DTO
{
    public class AspNetUserLogins
    {

        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public string UserId { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
