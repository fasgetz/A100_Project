using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class DeviationLocation
    {
        public DeviationLocation()
        {
            Deviation = new HashSet<Deviation>();
        }

        public int DeviationLocationId { get; set; }
        public string DeviationLocationName { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }
    }
}
