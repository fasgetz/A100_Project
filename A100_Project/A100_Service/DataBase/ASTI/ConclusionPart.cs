namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConclusionPart")]
    public partial class ConclusionPart
    {
        public int ConclusionPartID { get; set; }

        [Required]
        public string ConclusionRow { get; set; }

        [Required]
        [StringLength(15)]
        public string ConclusionRowName { get; set; }
    }
}
