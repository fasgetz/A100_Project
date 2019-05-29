namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportBoltedJoint
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoltedJointID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        public decimal? FrameAverageValue { get; set; }

        public decimal? AnchorAverageValue { get; set; }
    }
}
