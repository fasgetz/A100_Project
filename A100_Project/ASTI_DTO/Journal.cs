namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Journal
    {
        public int JournalID { get; set; }

        public int JournalCategoryID { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public string UserName { get; set; }

        public int WarehouseID { get; set; }

        public virtual JornalCategory JornalCategory { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
