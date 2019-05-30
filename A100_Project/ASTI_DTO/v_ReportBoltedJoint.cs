namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ReportBoltedJoint
    {
        public int BoltedJointID { get; set; }

        public int SpecificationsID { get; set; }

        public int ResoultID { get; set; }

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public string StillageTypeName { get; set; }

        public decimal? FrameAverageValue { get; set; }

        public decimal? AnchorAverageValue { get; set; }
    }
}
