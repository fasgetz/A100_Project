namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportSpecifications
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsID { get; set; }

        public int? StillageTypeID { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        public int? ResoultID { get; set; }
    }
}
