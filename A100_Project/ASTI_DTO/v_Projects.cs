namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_Projects
    {
        public int WarhouseID { get; set; }

        public int? CompanyID { get; set; }

        public string WarhouseName { get; set; }

        public int? CityID { get; set; }

        public int? MetodID { get; set; }

        public DateTime? ControlData { get; set; }

        public int? EmployeeID { get; set; }

        public string ProjectNumber { get; set; }

        public int ControlID { get; set; }

        public int ResoultID { get; set; }
        public string ControlName { get; set; }

        public string ProjectComment { get; set; }
    }
}
