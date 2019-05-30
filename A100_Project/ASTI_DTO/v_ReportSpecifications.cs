namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ReportSpecifications
    {
        public int SpecificationsID { get; set; }

        public int? StillageTypeID { get; set; }

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        public string StillageTypeName { get; set; }

        public int? ResoultID { get; set; }
    }
}
