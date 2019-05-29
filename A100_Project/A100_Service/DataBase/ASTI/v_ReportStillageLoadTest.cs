namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportStillageLoadTest
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StillageTestID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [StringLength(20)]
        public string Row { get; set; }

        [StringLength(12)]
        public string Frame { get; set; }

        public byte? levelCount { get; set; }

        public DateTime? StillageTestDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte ProtokolNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool isLoaded { get; set; }

        public int? MaxPassportLoad { get; set; }

        public int? UsualLoad { get; set; }

        public int? TestLoad { get; set; }

        public double? FuprFact { get; set; }

        public double? FostFast { get; set; }

        public double? DevLoadFact { get; set; }

        public double? F1fact { get; set; }

        public double? FkFact { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(300)]
        public string WarhouseAddress { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FrameElementID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoadElementID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoikaElementID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? BalkaEH { get; set; }

        public decimal? BalkaEB { get; set; }

        public decimal? BalkaEL { get; set; }

        public decimal? StoikaEB { get; set; }

        public decimal? StoikaEH { get; set; }

        public decimal? FrameEB { get; set; }

        public decimal? FrameEH { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MapID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsID { get; set; }
    }
}
