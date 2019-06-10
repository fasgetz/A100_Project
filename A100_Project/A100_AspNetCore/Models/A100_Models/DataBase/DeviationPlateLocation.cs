using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class DeviationPlateLocation
    {
        public DeviationPlateLocation()
        {
            Deviation = new HashSet<Deviation>();
        }

        public int DeviationPlateLocationId { get; set; }
        public string DeviationPlateLocationName { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }
    }
}
