namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public partial class v_GetControl
    {
        public string InspectionMetod { get; set; }

        public DateTime? ControlData { get; set; }

        public int ResoultID { get; set; }

        public string ProjectNumber { get; set; }

        public int? WarhouseID { get; set; }

        public string CompanyName { get; set; }

        public string WarhouseName { get; set; }

        public string ControlName { get; set; }

        public string ProjectComment { get; set; }

        public int? MetodID { get; set; }

        public int? ParentRID { get; set; }
    }
}
