namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportReferenceCheckList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BasicCheckListID { get; set; }

        public int? ResoultID { get; set; }

        [StringLength(250)]
        public string BasicDamageName { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte PhotoNumber { get; set; }

        [StringLength(1000)]
        public string BasicDamageDescription { get; set; }
    }
}
