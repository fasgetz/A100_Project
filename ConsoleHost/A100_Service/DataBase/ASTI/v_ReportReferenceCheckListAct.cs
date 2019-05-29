namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportReferenceCheckListAct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BasicCheckListID { get; set; }

        [StringLength(250)]
        public string BasicDamageName { get; set; }

        public int? ResoultID { get; set; }

        public string CSV { get; set; }

        [StringLength(1000)]
        public string BasicDamageDescription { get; set; }

        public byte? BasicDamageOrder { get; set; }
    }
}
