namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StockElements
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
