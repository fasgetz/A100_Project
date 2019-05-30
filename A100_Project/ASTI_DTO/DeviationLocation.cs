namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class DeviationLocation
    {
        public DeviationLocation()
        {
            Deviation = new HashSet<Deviation>();
        }

        public int DeviationLocationID { get; set; }

        public string DeviationLocationName { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }
    }
}
