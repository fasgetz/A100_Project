namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photomaterial")]
    public partial class Photomaterial
    {
        public int PhotomaterialID { get; set; }

        public byte PhotoNumber { get; set; }

        public int? BasicCheckListID { get; set; }

        public byte PhotoTypeID { get; set; }

        public int ResoultID { get; set; }

        [Required]
        [StringLength(250)]
        public string PhotoСaption { get; set; }

        [Required]
        public byte[] Photo { get; set; }

        public virtual BasicCheckList BasicCheckList { get; set; }

        public virtual PhotoType PhotoType { get; set; }
    }
}
