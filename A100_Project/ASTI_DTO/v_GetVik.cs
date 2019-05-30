namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetVik
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

        public int? SpecificationsElementID { get; set; }

        public int? ResoultID { get; set; }

        public int? TransformRow { get; set; }

        public string ElementOrientation { get; set; }

        public int? mScale { get; set; }

        public string FrameRange { get; set; }

        public int? PartialTOID { get; set; }

        public byte? ShowMode { get; set; }

        public int? EmployeeID { get; set; }

        public int? OriginalVikID { get; set; }

        public int? UniqueID { get; set; }

        public byte? OTKmark { get; set; }
    }
}
