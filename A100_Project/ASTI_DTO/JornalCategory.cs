namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class JornalCategory
    {
        public JornalCategory()
        {
            Journal = new HashSet<Journal>();
        }

        public int JornalCategoryID { get; set; }

        public string JornalCategoryName { get; set; }

        public int? WarehouseID { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        public virtual ICollection<Journal> Journal { get; set; }
    }
}
