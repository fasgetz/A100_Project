namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        public int LogID { get; set; }

        public byte PageID { get; set; }

        [StringLength(80)]
        public string QueryString { get; set; }

        public short ShortUserID { get; set; }

        [StringLength(20)]
        public string UserIPaddress { get; set; }

        public DateTime EventDateTime { get; set; }

        [StringLength(300)]
        public string EventInfo { get; set; }

        public int? ResoultID { get; set; }
    }
}
