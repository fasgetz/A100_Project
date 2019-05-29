namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportVik
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

        [StringLength(151)]
        public string StructuralMemberName { get; set; }

        [StringLength(50)]
        public string DefectName { get; set; }

        [StringLength(50)]
        public string RiscLevelName { get; set; }

        [StringLength(500)]
        public string cComment { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarhouseID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        public byte[] DamagePhoto { get; set; }

        [StringLength(32)]
        public string FrameRange { get; set; }

        public int? PartialTOID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public byte? ShowMode { get; set; }

        public int? EmployeeID { get; set; }
    }
}
