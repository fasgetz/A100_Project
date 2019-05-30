namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class DeviationPlateLocation
    {
        public DeviationPlateLocation()
        {
            Deviation = new HashSet<Deviation>();
        }

        public int DeviationPlateLocationID { get; set; }

        public string DeviationPlateLocationName { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }
    }
}
