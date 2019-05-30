namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetDeviationByUnit
    {
        public int DeviationID { get; set; }

        public int SpecificationsID { get; set; }

        public string UnitName { get; set; }

        public decimal? mX { get; set; }

        public decimal? mY { get; set; }

        public decimal? mRotation { get; set; }

        public int? DeviationPlateLocationID { get; set; }

        public int? WarhouseID { get; set; }

        public int? ResoultID { get; set; }

        public int? mScale { get; set; }

        public int? ArrowDirection { get; set; }

        public int? PlateCount { get; set; }

        public byte? ShowMode { get; set; }
    }
}
