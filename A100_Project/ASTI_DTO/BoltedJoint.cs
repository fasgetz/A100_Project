namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;


    public class BoltedJoint
    {
        public int BoltedJointID { get; set; }

        public int SpecificationsID { get; set; }

        public int ResoultID { get; set; }

        public decimal? FrameAverageValue { get; set; }

        public int? FrameMeasurementsCount { get; set; }

        public decimal? AnchorAverageValue { get; set; }

        public int? AnchorMeasurementsCount { get; set; }

        public int? TransformRow { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string FrameValues { get; set; }

        public string AnchorValues { get; set; }

        public string FrameAverageValueString { get; set; }

        public string AnchorAverageValueString { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }
    }
}
