using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class BoltedJoint
    {
        public int BoltedJointId { get; set; }
        public int SpecificationsId { get; set; }
        public int ResoultId { get; set; }
        public decimal? FrameAverageValue { get; set; }
        public int? FrameMeasurementsCount { get; set; }
        public decimal? AnchorAverageValue { get; set; }
        public int? AnchorMeasurementsCount { get; set; }
        public int? TransformRow { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string FrameValues { get; set; }
        public string AnchorValues { get; set; }
        public string FrameAverageValueString { get; set; }
        public string AnchorAverageValueString { get; set; }

        public virtual Resoult Resoult { get; set; }
        public virtual Specifications Specifications { get; set; }
    }
}
