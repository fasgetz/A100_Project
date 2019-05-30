namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetVikByUnit
    {
        public int VikID { get; set; }

        public string Row { get; set; }

        public int Frame { get; set; }


        public string nLevel { get; set; }

        public int? StructuralMemberID { get; set; }

        public int? DefectID { get; set; }

        public int? RiskLevelID { get; set; }

        public int? States { get; set; }

        public string cComment { get; set; }

        public decimal? mX { get; set; }

        public decimal? mY { get; set; }

        public decimal? mRotation { get; set; }

        public int? ResoultID { get; set; }

        public string UnitName { get; set; }

        public int? WarhouseID { get; set; }

        public int? ElementID { get; set; }

        public int? mScale { get; set; }

        public byte[] DamagePhoto { get; set; }

        public int SpecificationsID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string FrameRange { get; set; }

        public int? SpecificationsElementID { get; set; }

        public int? ElementCount { get; set; }

        public int? PartialTOID { get; set; }

        public byte? ShowMode { get; set; }

        public string Path { get; set; }
    }
}
