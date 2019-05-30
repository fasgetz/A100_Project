namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;


    public class City
    {
        public City()
        {
            Warhouse = new HashSet<Warhouse>();
        }

        public int CityID { get; set; }

        public string CityName { get; set; }

        public virtual ICollection<Warhouse> Warhouse { get; set; }
    }
}
