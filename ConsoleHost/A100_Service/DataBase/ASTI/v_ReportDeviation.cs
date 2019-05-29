namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportDeviation
    {
        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeviationID { get; set; }

        public int? SpecificationsID { get; set; }

        [StringLength(16)]
        public string Row { get; set; }

        public int? Frame { get; set; }

        public int? PlateCount { get; set; }

        public int? ResoultID { get; set; }

        public int? WarhouseID { get; set; }

        public int? DeviationValue { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string DeviationLocationName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string DeviationPlateLocationName { get; set; }

        public int? NullLevel { get; set; }

        public int? DeviationHeight { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        public int? EditValue { get; set; }

        [StringLength(32)]
        public string FrameRange { get; set; }

        public bool? StillageLoaded { get; set; }

        public bool? DeviationTypeCy { get; set; }

        [StringLength(26)]
        public string DeviationDirection { get; set; }

        public byte? ShowMode { get; set; }
    }
}
