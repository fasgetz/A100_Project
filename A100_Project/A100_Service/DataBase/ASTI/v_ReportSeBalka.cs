namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportSeBalka
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsElementID { get; set; }

        public int? SpecificationsID { get; set; }

        [StringLength(100)]
        public string ElementName { get; set; }

        public int? ResoultID { get; set; }

        public decimal? eH { get; set; }

        public decimal? eB { get; set; }

        public decimal? eL { get; set; }

        public decimal? eC { get; set; }

        public decimal? erb { get; set; }

        public int? barType { get; set; }
    }
}
