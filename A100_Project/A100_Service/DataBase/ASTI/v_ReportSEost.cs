namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportSEost
    {
        [StringLength(151)]
        public string El { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        public int? SpecificationsID { get; set; }

        public int? ResoultID { get; set; }

        public decimal? eH { get; set; }

        [StringLength(100)]
        public string ElementName { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }
    }
}
