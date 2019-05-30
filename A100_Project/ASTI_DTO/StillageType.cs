namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class StillageType
    {
        public StillageType()
        {
            Specifications = new HashSet<Specifications>();
        }

        public int StillageTypeID { get; set; }

        public string StillageTypeName { get; set; }

        public int? DeviationFactor { get; set; }

        public int? DeviationFactorLoaded { get; set; }

        public virtual ICollection<Specifications> Specifications { get; set; }
    }
}
