using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Deviation
    {
        public int DeviationId { get; set; }
        public int? SpecificationsId { get; set; }
        public int? Frame { get; set; }
        public int? DeviationValue { get; set; }
        public int? DeviationLocationId { get; set; }
        public int? PlateCount { get; set; }
        public int? DeviationPlateLocationId { get; set; }
        public int? ResoultId { get; set; }
        public int? EditValue { get; set; }
        public decimal? MX { get; set; }
        public decimal? MY { get; set; }
        public decimal? MRotation { get; set; }
        public int? TransformRow { get; set; }
        public int? NullLevel { get; set; }
        public int? DeviationHeight { get; set; }
        public int? DeviationOrientationId { get; set; }
        public int? ArrowDirection { get; set; }
        public int? MScale { get; set; }
        public int? EmployeeId { get; set; }
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
