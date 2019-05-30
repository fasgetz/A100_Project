namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ReportVik
    {

        public int VikID { get; set; }

        public string Row { get; set; }

        public int Frame { get; set; }


        public string nLevel { get; set; }

        public string StructuralMemberName { get; set; }

        public string DefectName { get; set; }

        public string RiscLevelName { get; set; }

        public string cComment { get; set; }

        public string CompanyName { get; set; }

        public string WarhouseName { get; set; }

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public string StillageTypeName { get; set; }

        public int WarhouseID { get; set; }

        public int ResoultID { get; set; }

        public string ElementSize { get; set; }

        public byte[] DamagePhoto { get; set; }

        public string FrameRange { get; set; }

        public int? PartialTOID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public byte? ShowMode { get; set; }

        public int? EmployeeID { get; set; }
    }
}
