namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public partial class v_ReportDamage
    {
        public int? WarhouseID { get; set; }

        public int? ResoultID { get; set; }

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public string element { get; set; }

        public int? Green { get; set; }

        public int? Yellow { get; set; }

        public int? Red { get; set; }

        public int? Сorrected { get; set; }

        public string StillageTypeName { get; set; }

        public string CompanyName { get; set; }

        public string WarhouseName { get; set; }

        public int SpecificationsID { get; set; }

        public int? ElementID { get; set; }
    }
}
