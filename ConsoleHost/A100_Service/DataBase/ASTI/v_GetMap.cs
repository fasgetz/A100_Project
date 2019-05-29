namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetMap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MapID { get; set; }

        public int? cIndex { get; set; }

        public decimal? X { get; set; }

        public decimal? Y { get; set; }

        public decimal? Width { get; set; }

        public decimal? Height { get; set; }

        [StringLength(16)]
        public string Row { get; set; }

        public int? Frame { get; set; }

        public int? Rotation { get; set; }

        public int? Iteration { get; set; }

        [StringLength(100)]
        public string MapUnit { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsID { get; set; }

        public int? WarhouseID { get; set; }

        [StringLength(50)]
        public string сLevel { get; set; }

        public int? TransformRow { get; set; }

        public int? ResoultID { get; set; }

        [StringLength(16)]
        public string FrameString { get; set; }

        public byte? ShowMode { get; set; }
    }
}
