namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Safety
    {
        public int SafetyID { get; set; }

        public DateTime Date { get; set; }

        public int WarhouseID { get; set; }

        public string InspectedBy { get; set; }

        public string ResponsiblePerson { get; set; }

        public virtual Safety Safety1 { get; set; }

        public virtual Safety Safety2 { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
