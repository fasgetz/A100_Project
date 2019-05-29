namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetDeviationByUnit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeviationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsID { get; set; }

        [StringLength(100)]
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
