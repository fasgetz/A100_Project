namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoltedJoint")]
    public partial class BoltedJoint
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

        [StringLength(1000)]
        public string FrameValues { get; set; }

        [StringLength(1000)]
        public string AnchorValues { get; set; }

        [StringLength(10)]
        public string FrameAverageValueString { get; set; }

        [StringLength(10)]
        public string AnchorAverageValueString { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }
    }
}
