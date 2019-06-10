using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class JornalCategory
    {
        public JornalCategory()
        {
            Journal = new HashSet<Journal>();
        }

        public int JornalCategoryId { get; set; }
        public string JornalCategoryName { get; set; }
        public int? WarehouseId { get; set; }

        public virtual Warhouse Warehouse { get; set; }
        public virtual ICollection<Journal> Journal { get; set; }
    }
}
