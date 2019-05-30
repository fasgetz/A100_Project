namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_RobustoVIK
    {

        public int Frame { get; set; }

        public string cComment { get; set; }


        public string Row { get; set; }

        public string FrameRange { get; set; }

        public string ElementSize { get; set; }

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        public int? ResoultID { get; set; }

        public string StillageTypeName { get; set; }

        public int? RiskLevelID { get; set; }
    }
}
