using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class DeviationOrientation
    {
        public DeviationOrientation()
        {
            Deviation = new HashSet<Deviation>();
        }

        public int DeviationOrientationId { get; set; }
        public string DeviationOrientationName { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }
    }
}
