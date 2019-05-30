namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ReportStillageLoadTest
    {
        public int StillageTestID { get; set; }

        public int ResoultID { get; set; }

        public string Row { get; set; }

        public string Frame { get; set; }

        public byte? levelCount { get; set; }

        public DateTime? StillageTestDate { get; set; }

        public byte ProtokolNumber { get; set; }

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

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }
        public string WarhouseName { get; set; }

        public string WarhouseAddress { get; set; }

        public string CompanyName { get; set; }

        public int FrameElementID { get; set; }

        public int LoadElementID { get; set; }

        public int StoikaElementID { get; set; }

        public string Name { get; set; }

        public decimal? BalkaEH { get; set; }

        public decimal? BalkaEB { get; set; }

        public decimal? BalkaEL { get; set; }

        public decimal? StoikaEB { get; set; }

        public decimal? StoikaEH { get; set; }

        public decimal? FrameEB { get; set; }

        public decimal? FrameEH { get; set; }

        public string StillageTypeName { get; set; }

        public int MapID { get; set; }

        public int SpecificationsID { get; set; }
    }
}
