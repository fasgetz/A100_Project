using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Journal
    {
        public int JournalId { get; set; }
        public int JournalCategoryId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public int WarehouseId { get; set; }

        public virtual JornalCategory JournalCategory { get; set; }
        public virtual Warhouse Warehouse { get; set; }
    }
}
