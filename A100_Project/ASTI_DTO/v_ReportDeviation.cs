namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ReportDeviation
    {
        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public string WarhouseName { get; set; }

        public string CompanyName { get; set; }

        public string StillageTypeName { get; set; }

        public int DeviationID { get; set; }

        public int? SpecificationsID { get; set; }

        public string Row { get; set; }

        public int? Frame { get; set; }

        public int? PlateCount { get; set; }

        public int? ResoultID { get; set; }

        public int? WarhouseID { get; set; }

        public int? DeviationValue { get; set; }

        public string DeviationLocationName { get; set; }

        public string DeviationPlateLocationName { get; set; }

        public int? NullLevel { get; set; }

        public int? DeviationHeight { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        public int? EditValue { get; set; }

        public string FrameRange { get; set; }

        public bool? StillageLoaded { get; set; }

        public bool? DeviationTypeCy { get; set; }

        public string DeviationDirection { get; set; }

        public byte? ShowMode { get; set; }
    }
}
