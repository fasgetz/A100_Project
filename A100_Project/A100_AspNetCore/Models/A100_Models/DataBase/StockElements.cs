using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class StockElements
    {
        public int StockElementsId { get; set; }
        public int WarhouseId { get; set; }
        public int SpecificationsElementId { get; set; }
        public int? ElementCount { get; set; }
        public int SpecificationsId { get; set; }

        public virtual Specifications Specifications { get; set; }
        public virtual Warhouse Warhouse { get; set; }
    }
}
