namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetVik
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VikID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string Row { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Frame { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(16)]
        public string nLevel { get; set; }

        public int? StructuralMemberID { get; set; }

        public int? DefectID { get; set; }

        public int? RiskLevelID { get; set; }

        public int? States { get; set; }

        [StringLength(500)]
        public string cComment { get; set; }

        public decimal? mX { get; set; }

        public decimal? mY { get; set; }

        public decimal? mRotation { get; set; }

        public int? SpecificationsElementID { get; set; }

        public int? ResoultID { get; set; }

        public int? TransformRow { get; set; }

        [StringLength(50)]
        public string ElementOrientation { get; set; }

        public int? mScale { get; set; }

        [StringLength(32)]
        public string FrameRange { get; set; }

        public int? PartialTOID { get; set; }

        public byte? ShowMode { get; set; }

        public int? EmployeeID { get; set; }

        public int? OriginalVikID { get; set; }

        public int? UniqueID { get; set; }

        public byte? OTKmark { get; set; }
    }
}
