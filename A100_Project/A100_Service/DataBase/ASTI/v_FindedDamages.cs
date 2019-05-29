namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_FindedDamages
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BasicCheckListID { get; set; }

        public int? ResoultID { get; set; }

        public byte? BasicDamageOrder { get; set; }

        [StringLength(1000)]
        public string BasicDamageDescriptionText { get; set; }

        [StringLength(800)]
        public string BasicDamageExt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BasicDamageID { get; set; }
    }
}
