namespace ASTI_DTO
{
    using System;

    public class Deviation
    {
        public int DeviationID { get; set; }

        public int? SpecificationsID { get; set; }

        public int? Frame { get; set; }

        public int? DeviationValue { get; set; }

        public int? DeviationLocationID { get; set; }

        public int? PlateCount { get; set; }

        public int? DeviationPlateLocationID { get; set; }

        public int? ResoultID { get; set; }

        public int? EditValue { get; set; }

        public decimal? mX { get; set; }

        public decimal? mY { get; set; }

        public decimal? mRotation { get; set; }

        public int? TransformRow { get; set; }

        public int? NullLevel { get; set; }

        public int? DeviationHeight { get; set; }

        public int? DeviationOrientationID { get; set; }

        public int? ArrowDirection { get; set; }

        public int? mScale { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string Row { get; set; }

        public string FrameRange { get; set; }

        public bool? StillageLoaded { get; set; }

        public bool? DeviationTypeCy { get; set; }

        public byte? ShowMode { get; set; }

        public virtual DeviationLocation DeviationLocation { get; set; }

        public virtual DeviationOrientation DeviationOrientation { get; set; }

        public virtual DeviationPlateLocation DeviationPlateLocation { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }
    }
}
