namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetElementsLoad
    {
        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        public string ElementSize { get; set; }

        public int? SpecificationsID { get; set; }

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public int? StillageTypeID { get; set; }

        public short? MaxLoad { get; set; }

        public string ElementName { get; set; }

        public int? ResoultID { get; set; }
    }
}
