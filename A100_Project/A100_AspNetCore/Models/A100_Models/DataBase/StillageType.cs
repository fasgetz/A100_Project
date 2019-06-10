using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class StillageType
    {
        public StillageType()
        {
            Specifications = new HashSet<Specifications>();
        }

        public int StillageTypeId { get; set; }
        public string StillageTypeName { get; set; }
        public int? DeviationFactor { get; set; }
        public int? DeviationFactorLoaded { get; set; }

        public virtual ICollection<Specifications> Specifications { get; set; }
    }
}
