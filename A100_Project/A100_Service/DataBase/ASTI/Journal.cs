namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Journal")]
    public partial class Journal
    {
        public int JournalID { get; set; }

        public int JournalCategoryID { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        public int WarehouseID { get; set; }

        public virtual JornalCategory JornalCategory { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
