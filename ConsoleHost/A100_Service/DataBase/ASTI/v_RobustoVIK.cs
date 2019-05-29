namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_RobustoVIK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Frame { get; set; }

        [StringLength(500)]
        public string cComment { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string Row { get; set; }

        [StringLength(32)]
        public string FrameRange { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        public int? ResoultID { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        public int? RiskLevelID { get; set; }
    }
}
