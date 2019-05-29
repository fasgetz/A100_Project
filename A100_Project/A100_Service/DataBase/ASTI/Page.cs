namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Page")]
    public partial class Page
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte PageID { get; set; }

        [StringLength(30)]
        public string PageAddress { get; set; }

        [StringLength(40)]
        public string PageName { get; set; }

        public byte? ObjectType { get; set; }
    }
}
