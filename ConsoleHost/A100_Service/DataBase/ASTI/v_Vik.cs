namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_Vik
    {
        [StringLength(500)]
        public string cComment { get; set; }

        public int? States { get; set; }

        public int? RiskLevelID { get; set; }

        public int? DefectID { get; set; }

        public int? StructuralMemberID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string nLevel { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Frame { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(16)]
        public string Row { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VikID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsElementID { get; set; }

        public int? SpecificationsID { get; set; }

        public int? ResoultID { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        public int? ElementID { get; set; }

        [StringLength(100)]
        public string ElementName { get; set; }

        [StringLength(50)]
        public string ElementOrientation { get; set; }

        public byte[] DamagePhoto { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(32)]
        public string FrameRange { get; set; }

        public int? PartialTOID { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(226)]
        public string Description { get; set; }

        public byte? ShowMode { get; set; }
    }
}
