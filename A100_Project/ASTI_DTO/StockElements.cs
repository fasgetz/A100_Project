namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class StockElements
    {
        public int StockElementsID { get; set; }

        public int WarhouseID { get; set; }

        public int SpecificationsElementID { get; set; }

        public int? ElementCount { get; set; }

        public int SpecificationsID { get; set; }

        public virtual Specifications Specifications { get; set; }

        public virtual StockElements StockElements1 { get; set; }

        public virtual StockElements StockElements2 { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
