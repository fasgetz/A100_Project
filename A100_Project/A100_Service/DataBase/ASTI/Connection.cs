namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Connection")]
    public partial class Connection
    {
        [Key]
        public int ConnetionKey { get; set; }

        public int? WKey { get; set; }

        [StringLength(250)]
        public string UserKey { get; set; }

        public bool Enabled { get; set; }

        public DateTime? ExperyDate { get; set; }
    }
}
