namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_LogEvents
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogID { get; set; }

        [StringLength(256)]
        public string Expr1 { get; set; }

        [StringLength(20)]
        public string UserIPaddress { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime EventDateTime { get; set; }

        [StringLength(80)]
        public string EventInfo { get; set; }

        [StringLength(70)]
        public string QueryString { get; set; }

        [StringLength(40)]
        public string PageName { get; set; }

        public int? ResoultID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        public int? WarhouseID { get; set; }
    }
}
