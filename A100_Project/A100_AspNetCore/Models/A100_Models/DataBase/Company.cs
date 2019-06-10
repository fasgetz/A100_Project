using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Company
    {
        public Company()
        {
            Licenses = new HashSet<Licenses>();
            Warhouse = new HashSet<Warhouse>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Licenses> Licenses { get; set; }
        public virtual ICollection<Warhouse> Warhouse { get; set; }
    }
}
