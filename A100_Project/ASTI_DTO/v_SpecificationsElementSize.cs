namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_SpecificationsElementSize
    {
        public int SpecificationsID { get; set; }

        public int? WarhouseID { get; set; }

        public string ManufacturedStillage { get; set; }

        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        public string ElementSize { get; set; }

        public string ElementName { get; set; }
    }
}
