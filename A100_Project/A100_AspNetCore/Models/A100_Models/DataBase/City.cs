using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class City
    {
        public City()
        {
            Warhouse = new HashSet<Warhouse>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Warhouse> Warhouse { get; set; }
    }
}
