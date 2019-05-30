using System.Collections.Generic;

namespace ASTI_DTO
{

    public class Company
    {
        public Company()
        {
            Warhouse = new HashSet<Warhouse>();
            Licenses = new HashSet<Licenses>();
        }

        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public virtual ICollection<Warhouse> Warhouse { get; set; }

        public virtual ICollection<Licenses> Licenses { get; set; }
    }
}
