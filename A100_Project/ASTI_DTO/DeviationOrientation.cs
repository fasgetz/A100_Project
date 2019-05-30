namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class DeviationOrientation
    {
        public DeviationOrientation()
        {
            Deviation = new HashSet<Deviation>();
        }

        public int DeviationOrientationID { get; set; }

        public string DeviationOrientationName { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }
    }
}
